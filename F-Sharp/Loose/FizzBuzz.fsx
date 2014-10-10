type NumberChecker = int -> string option

let checkNumber (divisor, message) number = 
    if number % divisor = 0 then
        Some message
    else    
        None

let fizz = checkNumber (3, "Fizz!")
let buzz = checkNumber (5, "Buzz!")

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
