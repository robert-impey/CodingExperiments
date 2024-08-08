// Comparing a list to a seq

let max = pown 10 2

let p x = printfn "%d" x 

let firstUpToMaxList = [1..max]
firstUpToMaxList |> List.iter p

let firstUpToMaxSeq = seq { for i in 1 .. max do yield i }
firstUpToMaxSeq |> Seq.iter p
