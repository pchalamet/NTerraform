module OutFile
open System.IO

let Write plugin category typeName ext lines =
    let catDir = category + "s"
    let tfnDir = typeName

    Directory.CreateDirectory(catDir) |> ignore
    let outfile = sprintf "%s/%s.%s" catDir tfnDir ext
    File.WriteAllLines(outfile, lines |> Array.ofSeq)
