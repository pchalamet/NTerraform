module GeneratorCSharp
open TerraformSchema
open System.IO
open System
open StringHelpers



//let pluralize (field : Field) name =
    //match field with
    //| { Name = _
    //    Modifier = _
    //    Cardinality = Cardinality.Range _
    //    Type = _ } -> name + "s"
    //| _ -> name

// C# 8.0
//let toNullable = function
    //| Cardinality.Optional -> "?"
    //| Cardinality.Range (None, _) -> "?"
    //| _ -> ""

let toNullable (field : Field) =
    match field.Type, field.Cardinality with
    | Primitive Primitive.Bool, Cardinality.Optional -> "?"
    | Primitive Primitive.Number, Cardinality.Optional -> "?"
    | _ -> ""

// C# 8.0
//let initNullable = function
    //| Cardinality.Optional -> " = null"
    //| Cardinality.Range (None, _) -> " = null"
    //| _ -> ""     

let initNullable (field : Field) =
    match field.Type, field.Cardinality with
    | _, Cardinality.Optional -> " = null"
    | _, Cardinality.Range (None, _) -> " = null"
    | _ -> ""


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
            let baseClass = match tfType with
                            | Some x -> sprintf " : NTerraform.%s" x
                            | _ -> ""
            yield sprintf "%spublic class %s%s" space4 className baseClass
            yield sprintf "%s{" space4

            yield! generateFields fields

            let primitiveParameters = fields |> List.filter (fun x -> x.Cardinality = Cardinality.Required)
            let rangeParameters = fields |> List.filter (fun x -> match x.Cardinality with
                                                                  | Cardinality.Range (Some _, _) -> true
                                                                  | _ -> false)

            let optPrimitiveParameters = fields |> List.filter (fun x -> x.Cardinality = Cardinality.Optional)
            let optRangeParameters = fields |> List.filter (fun x -> match x.Cardinality with
                                                                     | Cardinality.Range (None, _) -> true
                                                                     | _ -> false)
            let orderedParameters = (primitiveParameters @ rangeParameters |> List.sortBy (fun x -> x.Name))
                                    @ (optPrimitiveParameters @ optRangeParameters |> List.sortBy (fun x -> x.Name))

            let ctor = sprintf "%spublic %s(" space8 className
            let ctorIndent = System.String(' ', ctor.Length)
            let ctorPrms = orderedParameters
                               |> List.filter (fun x -> x.Modifier = Modifier.In)
                               |> List.map (fun x -> sprintf "%s%s @%s%s" (toTypeName x.Name x.Type)
                                                                          (toNullable x)
                                                                          (x.Name |> toCamlCase)
                                                                          (initNullable x))
                               |> generateCtor ctor ctorIndent ")"

            let ctorInit = orderedParameters
                               |> List.filter (fun x -> x.Modifier = Modifier.In)
                               |> List.map (fun x -> sprintf "%s@%s = @%s;" space12
                                                                            (x.Name |> toPascalCase)
                                                                            (x.Name |> toCamlCase))

            let members = orderedParameters
                               |> List.map (fun x -> sprintf "%spublic %s%s @%s { get; }" space8
                                                                                        (toTypeName x.Name x.Type)
                                                                                        (toNullable x)
                                                                                        (x.Name |> toPascalCase))

            yield! ctorPrms
            yield sprintf "%s{" space8
            yield! ctorInit
            yield sprintf "%s}" space8
            yield ""
            yield! members
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

 