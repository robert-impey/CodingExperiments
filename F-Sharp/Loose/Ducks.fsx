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

type ISpeaker = 
    abstract Speak : unit -> string

type Cat () =
    interface ISpeaker with
        member this.Speak () = "Meow!"

type Canary () =
    interface ISpeaker with
        member this.Speak () = "Tweet!"

let speakWithInterface (speaker : ISpeaker) =
    let x = speaker.Speak()
    printfn "With an interface, it said %s" x

let sylvester = Cat()
let tweetyPie = Canary()
speakWithInterface sylvester
speakWithInterface tweetyPie
