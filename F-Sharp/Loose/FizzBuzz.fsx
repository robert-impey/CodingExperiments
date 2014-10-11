type NumberChecker = int -> string option

let isEven x = 
    if x % 2 = 0 then Some "That number's even!"
    else None

let number = 4

match isEven number with
| Some message -> printfn "%s" message
| None -> printfn "%d" number

let isOdd x =
    if x % 2 = 1 then Some "That number's odd!"
    else None

match isOdd number with
| Some message -> printfn "%s" message
| None -> printfn "%d" number

let otherNumber = 5
match isOdd otherNumber with
| Some message -> printfn "%s" message
| None -> printfn "%d" otherNumber

let numberCheckerPrinter (numberChecker : NumberChecker) number =
    match numberChecker number with
    | Some message -> printfn "%s" message
    | None -> printfn "%d" number

numberCheckerPrinter isEven 2
numberCheckerPrinter isEven 3
numberCheckerPrinter isOdd 2
numberCheckerPrinter isOdd 3

let divisorNumberChecker (divisor, message) number = 
    if number % divisor = 0 then
        Some message
    else    
        None

let fizz = divisorNumberChecker (3, "Fizz!")
let buzz = divisorNumberChecker (5, "Buzz!")

fizz 3
fizz 4

let andNumberChecker (f : NumberChecker, g : NumberChecker) x  = 
    match f x, g x with
    | Some messageF, Some messageG -> messageF + " " + messageG |> Some
    | _ -> None

let fizzBuzz = andNumberChecker (fizz, buzz)

let doManyChecks (numberCheckers : NumberChecker list) number =
    let message = 
        List.fold (fun message' numberChecker ->
            match message' with 
            | Some _ -> message'
            | None -> numberChecker number
        ) None numberCheckers
    match message with
    | Some message' -> printfn "%s" message'
    | None -> printfn "%d" number   

let doFizzBuzzChecks = doManyChecks [ fizzBuzz; fizz; buzz ]

doFizzBuzzChecks 3
doFizzBuzzChecks 4
doFizzBuzzChecks 5
doFizzBuzzChecks 15

[ 1 .. 30 ] |> List.iter doFizzBuzzChecks
