// Simulation of picking from a population
#load "ReproducingMarbles.fs"

open ReproducingMarbles

let population = 
    [ (Blue, 5000)
      (Brown, 5000) ]
    |> Map.ofList

let numberOfPicks = pown 10 7

let rec simPicks remainingPicks picks = 
    if remainingPicks = 0 then picks
    else 
        let newColour = pickFromPopulation population
        simPicks (remainingPicks - 1) (newColour :: picks)

let picks = simPicks numberOfPicks []
let newPopulation = colourListToPopulation picks

newPopulation
|> Map.toSeq
|> Seq.iter (fun (colour, count) -> printfn "%s - %d" (colourToString colour) count)
