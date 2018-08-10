module OutFile
open System.IO
open StringHelpers

let Write tfType tfName ext lines =
    let catDir = (tfType + "s") |> toPascalCase
    let tfnDir = tfName |> toPascalCase

    Directory.CreateDirectory(catDir) |> ignore
    let outfile = sprintf "%s/%s.%s" catDir tfnDir ext
    File.WriteAllLines(outfile, lines |> Array.ofSeq)
    
