module GeneratorDump
open TerraformSchema

let Generate tfType tfName structure =
    seq {
        match structure with
        | FieldType.Structure fields -> yield sprintf "%A" structure
        | _ -> failwith "Expecting Structure"
    }