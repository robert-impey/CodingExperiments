// See http://atrevido.net/blog/2008/08/31/Statically+Typed+Duck+Typing+In+F.aspx

let inline speak (a : ^a) = 
    let x = (^a : (member Speak : unit -> string) (a))
    printfn "It said %s" x

type Elephant () =
    member this.Speak () = "Roar!"

type Dog () =
    member this.Speak () = "Woof!"

let ellie = Elephant()
let rover = Dog()

speak ellie
speak rover
