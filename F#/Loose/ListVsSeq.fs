// Comparing a list to a seq
// Robert Impey 2013-08-21

let max = pown 10 3

let p x = printfn "%d" x 

let firstUpToMaxList = [1..max]
List.iter (printfn "%d") firstUpToMaxList

let firstUpToMaxSeq = seq { for i in 1 .. max do yield i }
Seq.iter p firstUpToMaxSeq
