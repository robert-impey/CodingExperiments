// Experiment to illustrate Genetic Drift
// See :
//  http://en.wikipedia.org/wiki/Genetic_drift#Analogy_with_marbles_in_a_jar
// (c) Robert Impey, 2015-02-22
#load "ReproducingMarbles.fs"

open ReproducingMarbles

let population = 
    [ (Blue, 50)
      (Brown, 50) ]
    |> Map.ofList

let numberOfGenerations = 50
let finalPopulation = evolve numberOfGenerations population

printPopulation finalPopulation
