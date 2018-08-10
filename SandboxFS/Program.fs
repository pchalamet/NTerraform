open AzurermVirtualNetwork

open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open Microsoft.FSharp.Quotations.DerivedPatterns


let toto = AzurermVirtualNetwork (addressSpace = ["toto"], 
                                  location = "location", 
                                  name = "name", 
                                  resourceGroupName = "rgn",
                                  dnsServers = ["Dns"])

let dumpExpr expr =
    let rec print expr =
        match expr with
        | Application(expr1, expr2) ->
            // Function application.
            print expr1
            printf " "
            print expr2
        | SpecificCall <@@ (+) @@> (_, _, exprList) ->
            // Matches a call to (+). Must appear before Call pattern.
            print exprList.Head
            printf " + "
            print exprList.Tail.Head
        | Call(exprOpt, methodInfo, exprList) ->
            // Method or module function call.
            match exprOpt with
            | Some expr -> print expr
            | None -> printf "%s" methodInfo.DeclaringType.Name
            printf ".%s(" methodInfo.Name
            if (exprList.IsEmpty) then printf ")" else
            print exprList.Head
            for expr in exprList.Tail do
                printf ","
                print expr
            printf ")"
        | Int32(n) ->
            printf "Int %d" n
        | Lambda(param, body) ->
            // Lambda expression.
            printf "Lambda (%s:%s) -> " param.Name (param.Type.ToString())
            print body
        | Let(var, expr1, expr2) ->
            // Let binding.
            if (var.IsMutable) then
                printf "let mutable %s = " var.Name
            else
                printf "let %s = " var.Name
            print expr1
            printf " in "
            print expr2
        | PropertyGet(_, propOrValInfo, _) ->
            printf "PropertyGet %s" propOrValInfo.Name
        | String(str) ->
            printf "String %s" str
        | Value(value, typ) ->
            printf "Value %s" (value.ToString())
        | Var(var) ->
            printf "Var %s" var.Name
        | _ -> printf "%s" (expr.ToString())
    print expr
    printfn ""

[<EntryPoint>]
let main argv =
//    printf "%A" toto.DnsServer


    let a = 42
    let exprLambda = <@ fun x -> x + 1 @>
    let exprCall = <@ toto.DnsServers @>

    dumpExpr exprCall

    0