open System
open System.Diagnostics


let GetCmdOutput (cmd : string) (args : string) : string =
    let psi = ProcessStartInfo (FileName = cmd,
                                Arguments = args,
                                UseShellExecute = false,
                                RedirectStandardOutput = true)
    use proc = Process.Start(psi)
    proc.WaitForExit()
    let content = proc.StandardOutput.ReadToEnd()
    content


let extract tfType tfName =
    let args = sprintf "%s show -format=json %s" tfType tfName
    let content = GetCmdOutput "tfschema" args
    let structure = content |> TerraformSchema.Load
    structure


let usage() =
    printfn "nterraform <lang> <out> <type> <name>"
    printfn "where:"
    printfn "  <lang>: cs, dump"
    printfn "  <out> : console, file"    
    printfn "  <type>: data, provider, resource"
    printfn "  <name>: name of the structure"


[<EntryPoint>]
let main argv =
    match argv with
    | [| lang; output; tfType; tfName |] -> let structure = extract tfType tfName
                                            let lines = match lang with
                                                        | "dump" -> GeneratorDump.Generate tfType tfName structure
                                                        | "cs" -> GeneratorCSharp.Generate tfType tfName structure
                                                        | _ -> failwithf "Unknown generator %A" lang
                                            match output with
                                            | "console" -> OutConsole.Write lines
                                            | "file" -> OutFile.Write tfType tfName lang lines
                                            | _ -> failwithf "Unknown output %A" output
    | _ -> usage()
    0
