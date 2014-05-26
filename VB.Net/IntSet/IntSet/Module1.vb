Module Module1

    Sub Main()
        Dim t1 = New NonEmpty(5, New Empty, New Empty)

        Console.WriteLine(t1)

        Dim t2 = t1.Incl(3)

        Console.WriteLine(t2)

        Dim t3 = t2.Incl(4)

        Console.WriteLine(t3)
    End Sub

End Module
