// Minimising the function 1.1 on page 6 of 
// Practical Genetic Algorithms by Randy and Sue Ellen Haupt
// http://www.amazon.co.uk/Practical-Genetic-Algorithms-Randy-Haupt/dp/0471455652/ref=sr_1_1?ie=UTF8&qid=1377162584&sr=8-1&keywords=practical+genetic+algorithms

// The function is
// f(x, y) = x * sin(4 * x) + 1.1 * y * sin( 2 * y )
// x >= 0 and x <= 10 and y >= 0 and y <= 10 
let f x y = x * sin (4.0 * x) + 1.1 * y * sin (2.0 * y)

let xMin = 0.0
let yMin = 0.0
let xMax = 10.0
let yMax = 10.0

// Minimum found by VB version
// See https://github.com/robert-impey/PracticalGeneticAlgorithms/blob/master/PracticalGeneticAlgorithms.Test/ExhaustiveSearchF1_1Tests.vb
let vbMinSln = f 9.039 8.668

printfn "The solution from VB: %f" vbMinSln

// Exhaustive search
let xStep = 0.01
let yStep = 0.01

let candidates = 
    seq {
        for x in xMin .. xStep .. xMax do
            for y in yMin .. yStep .. yMax do
                yield x, y, f x y
    }

let candidateSolution = xMin, yMin, f xMin yMin

let findMinimum currentMinSln candidateSln =
    let (_, _, currentMinCost) = currentMinSln
    let (_, _, candidateSlnCost) = candidateSln
    if currentMinCost > candidateSlnCost then candidateSln else currentMinSln

let minSln = Seq.fold findMinimum candidateSolution candidates

printfn "Min sln: %A" minSln
