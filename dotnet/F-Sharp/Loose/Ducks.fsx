// Duck Typing in F#
// (c) Robert Impey 2014-01-29

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

// A more conventional approach with an interface

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

// Generic Types
// We're not interested in the body part
type ISpeakingAnimalWithBodyPart<'a> =
    abstract Speak : unit -> string

type Proboscis = class end
type Tail = class end

type Tapir () = 
    interface ISpeakingAnimalWithBodyPart<Proboscis> with 
        member this.Speak () = "Snort!"

type Mouse () =
    interface ISpeakingAnimalWithBodyPart<Tail> with
        member this.Speak () = "Squeak!"

let speakAnimalWithBodyPart<'a> (animal : ISpeakingAnimalWithBodyPart<'a>) =
    let x = animal.Speak()
    printfn "The animal with a body part that we don't care about said %s" x

let tony = Tapir()
let jerry = Mouse()

speakAnimalWithBodyPart tony
speakAnimalWithBodyPart jerry
