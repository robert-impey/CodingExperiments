let doSomething times =
    let rec doSomething' times timesDone =
        printfn "%d and %d" times timesDone
        if times = timesDone then
            printfn "Done!\n"
        else
            printfn "Doing it again!\n"
            doSomething' times (timesDone + 1)
    doSomething' times 0

doSomething 5
