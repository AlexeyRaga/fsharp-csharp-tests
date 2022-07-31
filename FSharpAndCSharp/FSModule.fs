module FSharpAndCSharp.FSModule

let mutable count = 0
let add x y =
    count <- count + 1
    printfn $"Count: {count}"
    let res = x + y
    if res > 50 then x else res