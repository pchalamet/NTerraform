module StringHelpers
open System

let rec toPascalWord (strs : string list) =
    match strs with
    | str :: t -> str.Substring(0, 1).ToUpper() + str.Substring(1) + (toPascalWord t)
    | _ -> ""


let toCamlCase (str : string) =
    let words = str.Split('_', StringSplitOptions.RemoveEmptyEntries) 
                    |> List.ofArray
    words.[0] + (words.Tail |> toPascalWord)

let toPascalCase (str : string) =
    let words = str.Split('_', StringSplitOptions.RemoveEmptyEntries) 
                    |> List.ofArray
    words |> toPascalWord

let removeFirstWord (str : string) =
    let words = str.Split('_', StringSplitOptions.RemoveEmptyEntries) |> List.ofArray
    match words with
    | _ :: t -> String.Join('_', t)
    | _ -> str

