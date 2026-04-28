Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        For counter = 0 To 9
            For counter2 = 0 To 9
                Console.Write(counter2)
            Next
            Console.WriteLine(counter)
        Next
    End Sub
End Module
