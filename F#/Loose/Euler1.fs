// Using FS to solve the first Project Euler problem
// Robert Impey 2013-08-21

// See http://projecteuler.net/problem=1

let max = 999
let isDivisibleBy3Or5 = (fun x -> x % 3 = 0 || x % 5 = 0)

// Using a list
let listSum = 
    [0..max]
    |> List.filter isDivisibleBy3Or5
    |> List.sum

// Using a seq
let countingNumbers = 
    seq { 
        for i in 1 .. System.Int32.MaxValue do 
            printfn "Yielding: %d" i
            yield i 
    }

let firstUpToMax = Seq.take max countingNumbers

//firstUpToMax |> Seq.iter (printfn "%d")

let divisibleBy3Or5 = 
    query {
        for countingNumber in firstUpToMax do
        where (isDivisibleBy3Or5 countingNumber)
        select countingNumber
    }

let seqSum = Seq.sum divisibleBy3Or5

let noisySum total next =
    printfn "Adding %d to %d" next total
    total + next

let seqFoldSum = Seq.fold noisySum 0 <| divisibleBy3Or5
