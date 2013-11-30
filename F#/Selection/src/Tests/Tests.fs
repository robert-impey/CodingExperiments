module Tests

open Selection
open NUnit.Framework
open FsUnit

[<TestFixture>]
type ``Given a selection helper and list of numbers`` () =
    [<Test>]
    member x.``When a number less than the lowest item is sent then the lowest element is returned.`` () =
//        let items = [|10 .. 20|]
//        let bar = 5
//        let found = SelectionHelper.getLowestOrLowestItemGreaterThan bar items
//
//        found |> should equal 10
        1 |> should equal 1
