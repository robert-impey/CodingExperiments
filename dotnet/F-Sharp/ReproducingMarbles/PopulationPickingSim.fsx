// Simulation of picking from a population
#load "ReproducingMarbles.fs"

open ReproducingMarbles

let population = 
    [ (Blue, 1)
      (Brown, 1) ]
    |> Map.ofList

let numberOfPicks = pown 10 4

let rec simPicks remainingPicks picks = 
    if remainingPicks = 0 then picks
    else 
        let newColour = pickFromPopulation population
        simPicks (remainingPicks - 1) (newColour :: picks)

let picks = simPicks numberOfPicks []
let newPopulation = colourListToPopulation picks

printPopulation newPopulation
