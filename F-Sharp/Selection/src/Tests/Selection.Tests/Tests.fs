module Tests

open Selection
open NUnit.Framework
open FsUnit

[<TestFixture>]
type ``Given a selection helper and list of numbers`` () =
    let getItems () =
        [|10 .. 20|]

    [<Test>]
    member x.``When a number less than the lowest item is sent Then the lowest element should be returned.`` () =
        let items = getItems ()
        let bar = 5
        let found = SelectionHelper.getLowestOrLowestItemGreaterThan bar items

        found |> should equal 10

    [<Test>]
    member x.``When a number in range is sent Then the lowest item greater than that item should be returned`` () =
        let items = getItems ()
        let bar = 11
        let found = SelectionHelper.getLowestOrLowestItemGreaterThan bar items

        found |> should equal 12

    [<Test>]
    member x.``When a number equal to the max is sent Then none should be returned`` () =
        let items = getItems ()
        let bar = 20
        let found = SelectionHelper.getLowestOrLowestItemGreaterThan bar items

        found |> should be Null

    [<Test>]
    member x.``When a number greater than the max is sent Then none should be returned`` () =
        let items = getItems ()
        let bar = 30
        let found = SelectionHelper.getLowestOrLowestItemGreaterThan bar items

        found |> should be Null
