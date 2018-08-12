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

let rec toTypeName name primitive =
    match primitive with
    | Primitive Primitive.String -> "string"
    | Primitive Primitive.Bool -> "bool"
    | Primitive Primitive.Number -> "int"
    | FieldType.Collection (coll, fieldType) -> let declType = toTypeName name fieldType
                                                match coll with
                                                | Collection.Single -> declType
                                                | Collection.List -> sprintf "FSharpList<%s>" declType
                                                | Collection.Map -> sprintf "FSharpMap<string,%s>" declType
                                                | Collection.Set -> sprintf "FSharpList<%s>" declType
    | FieldType.Structure _ -> name

let assignEmpty (field : Field) =
    match field.Type, field.Cardinality with
    | FieldType.Collection (Collection.List, underlying), { Min = 0; Max = _ } -> sprintf " ?? FSharpList<%s>.Empty" (toTypeName field.Name underlying)
    | FieldType.Collection (Collection.Set, underlying), { Min = 0; Max = _ } -> sprintf " ?? FSharpList<%s>.Empty" (toTypeName field.Name underlying)
    | FieldType.Collection (Collection.Map, underlying), { Min = 0; Max = _ } -> sprintf " ?? MapModule.Empty<string,%s>()" (toTypeName field.Name underlying)
    | _ -> ""

let initNullable = function
    | { Min = 0; Max = _ } -> sprintf " = null"
    | _ -> ""

let nullableIntValue = function
    | Some x -> sprintf "%d" x
    | _ -> "null"




let rec generateType plugin category typeName fields =
    let rec generateStructure indent baseType name fields : string seq =
        let rec generateFields fields =
            seq {
                match fields with
                | { Name = fieldName
                    Modifier = _
                    Cardinality = _
                    Type = FieldType.Collection (coll, FieldType.Structure fieldType) } :: t -> yield! generateStructure (indent + 4) "structure" fieldName fieldType
                                                                                                yield! generateFields t
                | { Name = fieldName
                    Modifier = _
                    Cardinality = _
                    Type = FieldType.Structure fieldType } :: t -> yield! generateStructure (indent + 4) "structure" fieldName fieldType
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
                               |> List.map (fun x -> sprintf "%s@%s = @%s%s;" space12
                                                                            (x.Name |> toPascalCase)
                                                                            (x.Name |> toCamlCase)
                                                                            (assignEmpty x))
                                                                            
            let attributes = orderedParameters
                                |> List.map (fun x -> sprintf "%s[nterraform.Core.TerraformProperty(name: %A, @out: %s, min: %d, max: %d)]"
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

            yield sprintf "%s[nterraform.Core.TerraformStructure(category: %A, typeName: %A)]" space4 category name
            yield sprintf "%spublic sealed class %s : nterraform.Core.%s" space4 className baseType
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
        yield "using Microsoft.FSharp.Collections;"
        yield ""
        match category with
        | "provider" -> yield sprintf "namespace nterraform.%s" (category + "s")
        | _ -> yield sprintf "namespace nterraform.%s" (category + "s")
        yield "{"
        yield! generateStructure 0 category typeName fields
        yield "}"
    }
    

let Generate plugin category typeName structure =
    match structure with
    | FieldType.Structure fields -> let lines = generateType plugin category typeName fields
                                    lines
    | _ -> failwith "Expecting Structure"

 