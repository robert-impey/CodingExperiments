module HelloWorld.Main

open System

[<EntryPoint>]
let main args = 
    let addressee = "world"
    printf "Hello, %s\n" addressee
    0
