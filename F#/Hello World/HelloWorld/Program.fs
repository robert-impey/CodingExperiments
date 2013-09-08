module HelloWorld.Main

open System

[<EntryPoint>]
let main args = 
    let addressee = 8
    printf "Hello, %s\n" addressee
    0
