module ColourList.Tests

open FsUnit.Xunit
open Xunit
open ReproducingMarbles

type ``Given an empty list When it is converted to a Population``() = 
    let colourList = []
    [<Fact>]
    member __.``Then the Population is empty``() = 
        colourList
        |> colourListToPopulation
        |> countPopulation
        |> should equal 0

type ``Given a list that is half and half When it is converted to a Population``() = 
    let colourList = [ Blue; Blue; Blue; Blue; Blue; Brown; Brown; Brown; Brown; Brown ]
    let population = colourListToPopulation colourList
    
    [<Fact>]
    member __.``Then the Population is 10``() = 
        population
        |> countPopulation
        |> should equal 10
    
    [<Fact>]
    member __.``Then there are 5 blues``() = population.[Blue] |> should equal 5
    
    [<Fact>]
    member __.``Then there are 5 browns``() = population.[Brown] |> should equal 5
