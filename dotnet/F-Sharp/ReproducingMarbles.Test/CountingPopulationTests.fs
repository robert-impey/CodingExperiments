module CountingPopulation.Tests

open FsUnit.Xunit
open Xunit
open ReproducingMarbles

type ``Given a population When it is counted``() = 
    
    let population = 
        [ (Blue, 50)
          (Brown, 50) ]
        |> Map.ofList
    
    [<Fact>]
    member __.``Then the count is correct``() = 
        population
        |> countPopulation
        |> should equal 100

type ``Given an empty population When it is counted``() = 
    let population = [] |> Map.ofList
    [<Fact>]
    member __.``Then the count is 0``() = 
        population
        |> countPopulation
        |> should equal 0
