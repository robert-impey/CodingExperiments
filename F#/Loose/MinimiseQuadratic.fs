// Trying to find the minimum of a quadratic curve
// Robert Impey 2013-08-22

// Using a seq to find the minium of a quadratic function

let f x = (x ** 2.0) - (2.0 * x) + 1.0

// We could solve this by finding the derivative
// dy / dx = 2 * x - 2 = 0
// Therefore x = 1

// Search from 0.0 to 10.0

let min = 0.0
let max = 10.0
let step = 0.01

let firstCandidate = f min, min

let remainingCandidates = seq { for c in min + step .. step .. max do yield f c, c }

let findMin currentMinSln candidateSln =
    match fst currentMinSln < fst candidateSln with
    | true -> currentMinSln
    | false -> candidateSln

let minSln = Seq.fold findMin firstCandidate remainingCandidates
