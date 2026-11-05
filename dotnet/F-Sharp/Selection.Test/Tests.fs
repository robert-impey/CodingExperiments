module Tests

open Selection
open Xunit
open FsUnit.Xunit

type ``Given a selection helper and sequence of integers`` () =
    let getItems () =
       seq { 10 .. 20 }

    [<Fact>]
    member x.``When a number less than the lowest item is sent Then the lowest element should be returned.`` () =
        let items = getItems ()
        let bar = 5
        let found = SelectionHelper.getLowestOrLowestItemGreaterThan bar items

        found |> should equal (Some 10)

    [<Fact>]
    member x.``When a number in range is sent Then the lowest item greater than that item should be returned`` () =
        let items = getItems ()
        let bar = 11
        let found = SelectionHelper.getLowestOrLowestItemGreaterThan bar items

        found |> should equal (Some 12)

    [<Fact>]
    member x.``When a number equal to the max is sent Then none should be returned`` () =
        let items = getItems ()
        let bar = 20
        let found = SelectionHelper.getLowestOrLowestItemGreaterThan bar items

        found |> should equal None

    [<Fact>]
    member x.``When a number greater than the max is sent Then none should be returned`` () =
        let items = getItems ()
        let bar = 30
        let found = SelectionHelper.getLowestOrLowestItemGreaterThan bar items

        found |> should equal None

type ``Given an empty sequence of integers`` () =
    [<Fact>]
    member x.``When a number is sent Then none should be returned`` () =
        SelectionHelper.getLowestOrLowestItemGreaterThan 10 Seq.empty |> should equal None

type ``Given a very large sequence of integers`` () =
    [<Fact>]
    member x.``When a number is sent Then the next number should be returned`` () =
        let items = seq { for i in 1 .. pown 2 30 do yield i }
        SelectionHelper.getLowestOrLowestItemGreaterThan 10 items |> should equal (Some 11)
