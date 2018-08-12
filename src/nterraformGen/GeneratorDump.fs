module GeneratorDump
open TerraformSchema

let Generate plugin category typeName structure =
    seq {
        match structure with
        | FieldType.Structure fields -> yield sprintf "%A" structure
        | _ -> failwith "Expecting Structure"
    }