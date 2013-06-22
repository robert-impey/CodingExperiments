Module Module1

    Sub Main()
        Console.WriteLine("Hello, world!")
        Console.WriteLine()

        For counter = 1 To 6
            Console.WriteLine("Hello!")
        Next
        Console.WriteLine()

        For counter1 = 1 To 20
            For counter2 = 1 To 20
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub

End Module
