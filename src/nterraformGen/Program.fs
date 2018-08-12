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
    printfn "nterraform <lang> <out> <plugin> <category> <typeName>"
    printfn "where:"
    printfn "  <lang>: cs, fs, dump"
    printfn "  <out> : console, file"    
    printfn "  <plugin> : name plugin (eg: azurerm)"    
    printfn "  <category>: data, provider, resource"
    printfn "  <typeName>: type name of the structure"


[<EntryPoint>]
let main argv =
    match argv with
    | [| lang; output; plugin; category; typeName |] -> let structure = extract category typeName
                                                        let lines = match lang with
                                                                    | "dump" -> GeneratorDump.Generate plugin category typeName structure
                                                                    | "cs" -> GeneratorCSharp.Generate plugin category typeName structure
                                                                    | _ -> failwithf "Unknown generator %A" lang
                                                        match output with
                                                        | "console" -> OutConsole.Write lines
                                                        | "file" -> OutFile.Write plugin category typeName lang lines
                                                        | _ -> failwithf "Unknown output %A" output
    | _ -> usage()
    0
