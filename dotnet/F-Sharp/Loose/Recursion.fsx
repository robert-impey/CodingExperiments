let doSomething times =
    let rec doSomething' timesDone =
        printfn "%d and %d" times timesDone
        if times = timesDone then
            printfn "Done!\n"
        else
            printfn "Doing it again!\n"
            doSomething' (timesDone + 1)
    doSomething' 0

doSomething 5
