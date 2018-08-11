﻿module GeneratorFSharp
open TerraformSchema
open System.IO
open System
open StringHelpers


let toOptional = function
    | Cardinality.Optional -> "?"
    | Cardinality.Range (None, _) -> "?"
    | _ -> ""

let rec toTypeName name primitive =
    match primitive with
    | Primitive Primitive.String -> "string"
    | Primitive Primitive.Bool -> "bool"
    | Primitive Primitive.Number -> "int"
    | FieldType.Collection (coll, fieldType) -> let declType = toTypeName name fieldType
                                                match coll with
                                                | Collection.Single -> declType
                                                | Collection.List -> sprintf "%s list" declType
                                                | Collection.Map -> sprintf "Map<string,%s>" declType
                                                | Collection.Set -> sprintf "%s list" declType
    | FieldType.Structure _ -> name 



let rec generateType name fields =
    let rec generateStructure name fields : string seq =
        let rec generateFields fields =
            seq {
                match fields with
                | { Name = fieldName
                    Modifier = _
                    Cardinality = _
                    Type = FieldType.Collection (coll, FieldType.Structure fieldType) } :: t -> yield! generateStructure fieldName fieldType
                                                                                                yield! generateFields t
                | { Name = fieldName
                    Modifier = _
                    Cardinality = _
                    Type = FieldType.Structure fieldType } :: t -> yield! generateStructure fieldName fieldType
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
            yield! generateFields fields

            let ctor = sprintf "type %s(" name
            let ctorIndent = System.String(' ', ctor.Length)

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

            let ctorPrms = orderedParameters
                               |> List.filter (fun x -> x.Modifier = Modifier.In)
                               |> List.map (fun x -> sprintf "%s``%s`` : %s" (toOptional x.Cardinality) 
                                                                          (x.Name |> toCamlCase) 
                                                                          (toTypeName x.Name x.Type))
                               |> generateCtor ctor ctorIndent ") ="
            let members = orderedParameters
                            |> List.filter (fun x -> x.Modifier = Modifier.In) // UNDONE: Out parameters not support as of now
                            |> List.map (fun x -> sprintf "    member this.``%s`` = ``%s``" (x.Name |> toPascalCase) 
                                                                                    (x.Name |> toCamlCase))

            yield! ctorPrms
            yield! members
            yield ""
        }

    seq {
        yield sprintf "module %s" (name |> toPascalCase)
        yield ""

        yield! generateStructure name fields
    }
    

let Generate tfType tfName structure =
    match structure with
    | FieldType.Structure fields -> let lines = generateType tfName fields
                                    lines
    | _ -> failwith "Expecting Structure"

 