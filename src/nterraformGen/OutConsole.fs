module OutConsole

let Write lines =
    lines |> Seq.iter (printfn "%s")
