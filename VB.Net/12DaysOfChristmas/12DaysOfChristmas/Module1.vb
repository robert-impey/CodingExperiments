Module Module1

    Sub Main()
        Dim totalNumberOfItems = 0

        For dayOfChristmas = 1 To 12
            For numberOfItems = 1 To dayOfChristmas
                totalNumberOfItems += numberOfItems
            Next
        Next

        Console.WriteLine("Total number of Items: " & totalNumberOfItems)
    End Sub

End Module
