type NumberChecker = int -> string option

let isEven x = 
    if x % 2 = 0 then Some "That number's even!"
    else None

let numberCheckerPrinter (numberChecker : NumberChecker) number =
    match numberChecker number with
    | Some message -> printfn "%s" message
    | None -> printfn "%d" number

numberCheckerPrinter isEven 2
numberCheckerPrinter isEven 3

let numberCheckerMaker (divisor, message) number = 
    if number % divisor = 0 then
        Some message
    else    
        None

let fizz = numberCheckerMaker (3, "Fizz!")
let buzz = numberCheckerMaker (5, "Buzz!")

let andNumberChecker (f : NumberChecker, g : NumberChecker) = 
    (fun x -> 
        match f x, g x with
        | Some messageF, Some messageG -> messageF + " " + messageG |> Some
        | _ -> None
    )

let fizzBuzz = andNumberChecker (fizz, buzz)

let numberCheckers = [ fizzBuzz; fizz; buzz ]

[1 .. 30 ]
|> List.iter (fun x -> 
    let message = 
        List.fold (fun message' numberChecker ->
            match message' with 
            | Some _ -> message'
            | None -> numberChecker x
        ) None numberCheckers
    match message with
    | Some message' -> printfn "%s" message'
    | None -> printfn "%d" x)
