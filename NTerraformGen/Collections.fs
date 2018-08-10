module Collections

let join (p:Map<'a,'b>) (q:Map<'a,'b>) = 
    Map(Seq.concat [ (Map.toSeq p) ; (Map.toSeq q) ])

let (?) cond (a, b) = 
    match cond with
    | true -> a
    | _ -> b
