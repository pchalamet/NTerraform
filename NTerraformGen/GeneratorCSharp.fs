module GeneratorCSharp

open TerraformSchema
open System
open StringHelpers
open Collections


// C# 8.0
//let toNullable = function
    //| Cardinality.Optional -> "?"
    //| Cardinality.Range (None, _) -> "?"
    //| _ -> ""

let toNullable (field : Field) =
    match field.Type, field.Cardinality with
    | Primitive Primitive.Bool, { Min = 0; Max = _ } -> "?"
    | Primitive Primitive.Number, { Min = 0; Max = _ } -> "?"
    | _ -> ""

// C# 8.0
//let initNullable = function
    //| Cardinality.Optional -> " = null"
    //| Cardinality.Range (None, _) -> " = null"
    //| _ -> ""     

let initNullable = function
    | { Min = 0; Max = _ } -> " = null"
    | _ -> ""

let nullableIntValue = function
    | Some x -> sprintf "%d" x
    | _ -> "null"

let rec toTypeName name primitive =
    match primitive with
    | Primitive Primitive.String -> "string"
    | Primitive Primitive.Bool -> "bool"
    | Primitive Primitive.Number -> "int"
    | FieldType.Collection (coll, fieldType) -> let declType = toTypeName name fieldType
                                                match coll with
                                                | Collection.Single -> declType
                                                | Collection.List -> sprintf "%s[]" declType
                                                | Collection.Map -> sprintf "Dictionary<string,%s>" declType
                                                | Collection.Set -> sprintf "%s[]" declType
    | FieldType.Structure _ -> name



let rec generateType tfType tfName fields =
    let rec generateStructure indent (tfType : string option) name fields : string seq =
        let rec generateFields fields =
            seq {
                match fields with
                | { Name = fieldName
                    Modifier = _
                    Cardinality = _
                    Type = FieldType.Collection (coll, FieldType.Structure fieldType) } :: t -> yield! generateStructure (indent + 4) None fieldName fieldType
                                                                                                yield! generateFields t
                | { Name = fieldName
                    Modifier = _
                    Cardinality = _
                    Type = FieldType.Structure fieldType } :: t -> yield! generateStructure (indent + 4) None fieldName fieldType
                                                                   yield! generateFields t
                | _ -> ()
            }

        let rec generateCtor header sep footer prms =
            seq {
                match prms with
                | [] -> yield sprintf "%s%s" header footer
                | [prm] -> yield sprintf "%s%s%s" header prm footer
                | prm :: t -> yield sprintf "%s%s," header prm
                              yield! generateCtor sep sep footer t
            }
 
        seq {
            let space4 = System.String(' ', 4 + indent)
            let space8 = System.String(' ', 8 + indent)
            let space12 = System.String(' ', 12 + indent)

            let className = name
            let category, baseClass = match tfType with
                                      | Some x -> x, sprintf " : NTerraform.%s" x
                                      | _ -> "", ": NTerraform.structure"
            let parameters = fields |> List.filter (fun x -> x.Cardinality.Min <> 0)
            let optParameters = fields |> List.filter (fun x -> x.Cardinality.Min = 0)
            let orderedParameters = (parameters |> List.sortBy (fun x -> x.Name))
                                    @ (optParameters |> List.sortBy (fun x -> x.Name))

            let ctor = sprintf "%spublic %s(" space8 className
            let ctorIndent = System.String(' ', ctor.Length)
            let ctorPrms = orderedParameters
                               |> List.filter (fun x -> x.Modifier = Modifier.In)
                               |> List.map (fun x -> sprintf "%s%s @%s%s" (toTypeName x.Name x.Type)
                                                                          (toNullable x)
                                                                          (x.Name |> toCamlCase)
                                                                          (initNullable x.Cardinality))
                               |> generateCtor ctor ctorIndent ")"

            let ctorInit = orderedParameters
                               |> List.filter (fun x -> x.Modifier = Modifier.In)
                               |> List.map (fun x -> sprintf "%s@%s = @%s;" space12
                                                                            (x.Name |> toPascalCase)
                                                                            (x.Name |> toCamlCase))
                                                                            
            let attributes = orderedParameters
                                |> List.map (fun x -> sprintf "%s[TerraformProperty(name: %A, @out: %s, min: %d, max: %d)]"
                                                            space8
                                                            x.Name
                                                            ((x.Modifier = Modifier.Out) ? ("true", "false"))
                                                            x.Cardinality.Min x.Cardinality.Max)

            let members = orderedParameters
                               |> List.map (fun x -> sprintf "%spublic %s%s @%s { get; }" space8
                                                                                        (toTypeName x.Name x.Type)
                                                                                        (toNullable x)
                                                                                        (x.Name |> toPascalCase))

            let attrXmembers = List.zip attributes members

            yield sprintf "%s[TerraformStructure(category: %A, typeName: %A)]" space4 category name
            yield sprintf "%spublic sealed class %s%s" space4 className baseClass
            yield sprintf "%s{" space4

            yield! generateFields fields

            yield! ctorPrms
            yield sprintf "%s{" space8
            yield! ctorInit
            yield sprintf "%sbase._validate_();" space12
            yield sprintf "%s}" space8
            for attrXmember in attrXmembers do
                yield ""
                yield attrXmember |> fst
                yield attrXmember |> snd
            yield sprintf "%s}" space4
            yield ""
        }

    seq {
        yield "using System.Collections.Generic;"
        yield ""
        yield sprintf "namespace NTerraform.%s" ((tfType + "s") |> toPascalCase)
        yield "{"
        yield! generateStructure 0 (Some tfType) tfName fields
        yield "}"
    }
    

let Generate tfType tfName structure =
    match structure with
    | FieldType.Structure fields -> let lines = generateType tfType tfName fields
                                    lines
    | _ -> failwith "Expecting Structure"

 