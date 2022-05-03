module CountingPopulation.Tests

open FsUnit
open NUnit.Framework
open ReproducingMarbles

[<TestFixture>]
type ``Given a population When it is counted``() = 
    
    let population = 
        [ (Blue, 50)
          (Brown, 50) ]
        |> Map.ofList
    
    [<Test>]
    member __.``Then the count is correct``() = 
        population
        |> countPopulation
        |> should equal 100

[<TestFixture>]
type ``Given an empty population When it is counted``() = 
    let population = [] |> Map.ofList
    [<Test>]
    member __.``Then the count is 0``() = 
        population
        |> countPopulation
        |> should equal 0
