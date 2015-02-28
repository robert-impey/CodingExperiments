// Experiment to illustrate Genetic Drift
// See :
//  http://en.wikipedia.org/wiki/Genetic_drift#Analogy_with_marbles_in_a_jar
// (c) Robert Impey, 2015-02-22
#load "ReproducingMarbles.fs"

open ReproducingMarbles

let population = 
    [ (Blue, 10)
      (Brown, 10) ]
    |> Map.ofList

let numberOfGenerations = pown 10 4
let finalPopulation = evolve numberOfGenerations population

printPopulation finalPopulation
