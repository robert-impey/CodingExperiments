// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System.Diagnostics

[<EntryPoint>]
let main argv = 
    let size = pown 10 7
    let f x = x + x

    let stopWatch = Stopwatch()

    stopWatch.Start()
    let xs = seq { 1 ..  size }
    xs |> Seq.map f |> Seq.toArray |> ignore
    stopWatch.Stop()

    printfn "Time to run one loop with many iterations: %d" stopWatch.ElapsedMilliseconds

    stopWatch.Restart()
    let ys = [| 0 .. 9 |]
    for _ in 1 .. size do
        Array.map f ys |> ignore
    stopWatch.Stop()

    printfn "Time to run many loops with few iterations: %d" stopWatch.ElapsedMilliseconds
    
    0 // return an integer exit code
