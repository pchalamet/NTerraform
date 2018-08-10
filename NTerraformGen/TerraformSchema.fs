module TerraformSchema
open System.Text.RegularExpressions
open Newtonsoft.Json
open Collections


// This is the internal schema model
type Modifier =
    | In
    | Out

type Cardinality =
    | Optional
    | Required
    | Range of int option*int option

type Collection =
    | Single
    | List
    | Set
    | Map

type Primitive =
    | String
    | Bool
    | Number

type FieldType =
    | Primitive of Primitive
    | Structure of Field list
    | Collection of Collection * FieldType

and Field = { Name : string
              Modifier : Modifier
              Cardinality : Cardinality
              Type : FieldType }


// Types for deserialization directly using json.net
type TFAttribute =
    { Name : string
      Type : string
      Required : bool
      Optional : bool
      Computed : bool
      Sensitive : bool }

type TFBlockType =
    { Name : string
      Attributes : array<TFAttribute>
      [<JsonProperty("block_types")>] BlockTypes : array<TFBlockType>
      Nesting : int
      [<JsonProperty("min_items")>] MinItems : int
      [<JsonProperty("max_items")>] MaxItems : int }

type TFSchema =
    { Attributes : array<TFAttribute> 
      [<JsonProperty("block_types")>]
      BlockTypes : array<TFBlockType> }




let (|Regex|_|) pattern input =
    let m = Regex.Match(input, pattern)
    if m.Success then [ for g in m.Groups -> g.Value ] |> List.tail |> Some
    else None


let rec parseType (typeDef : string) : FieldType =
    match typeDef with
    | "String" -> Primitive Primitive.String
    | "Bool" -> Primitive Primitive.Bool
    | "Number" -> Primitive Primitive.Number
    | Regex "List\((.+)\)" [stype] -> FieldType.Collection (Collection.List, parseType stype)
    | Regex "Set\((.+)\)" [stype] ->  FieldType.Collection (Collection.Set, parseType stype)
    | Regex "Map\((.+)\)" [stype] -> FieldType.Collection (Collection.Map, parseType stype)
    | x -> failwithf "Unknown type %s" x


let convertAttributeToField (attribute : TFAttribute) : Field =
    let fieldName = attribute.Name
    let fieldOpt = attribute.Required ? (Cardinality.Required, Cardinality.Optional)
    let fieldMod = attribute.Computed ? (Modifier.Out, Modifier.In) 
    let fieldType = attribute.Type |> parseType
    { Name = fieldName
      Modifier = fieldMod
      Cardinality = fieldOpt
      Type = fieldType }

let rec convertSchemaToStructure (attributes : TFAttribute seq) (blockTypes : TFBlockType seq) =
    let convertToCollection = function
                              | 1 -> Collection.Single
                              | 2 -> Collection.List
                              | 3 -> Collection.Set
                              | 4 -> Collection.Map
                              | x -> failwithf "Unknown collection type %d" x

    let toBound = function 
                  | 0 -> None 
                  | x -> Some x        

    let convertBlockTypeToField (blockType : TFBlockType) : Field =
        let structName = blockType.Name
        let structure = convertSchemaToStructure blockType.Attributes blockType.BlockTypes
        let collType = FieldType.Collection (convertToCollection blockType.Nesting, structure)
        let minCard = blockType.MinItems |> toBound
        let maxCard = blockType.MaxItems |> toBound
        let card = match minCard, maxCard with
                   | Some 0, Some 1 -> Cardinality.Optional
                   | Some 1, Some 1 -> Cardinality.Required
                   | _ -> Cardinality.Range (minCard, maxCard)
        { Name = structName
          Modifier = Modifier.In
          Cardinality = card
          Type = collType }

    let attributes = attributes |> Seq.map convertAttributeToField
    let blockTypes = blockTypes |> Seq.map convertBlockTypeToField
    let fields = attributes |> Seq.append blockTypes |> List.ofSeq
    let structure = Structure fields
    structure  


let Load (content : string) =
    let schema = JsonConvert.DeserializeObject<TFSchema>(content)
    let structure = convertSchemaToStructure schema.Attributes schema.BlockTypes
    structure
    