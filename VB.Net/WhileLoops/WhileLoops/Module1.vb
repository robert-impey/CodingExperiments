Module Module1

    Sub Main()
        Dim counter = 1
        Dim sum = 0

        While counter <= 100
            sum = sum + counter
            Console.WriteLine("Counter: " & counter)
            counter = counter + 1
        End While

        Console.WriteLine(sum)
    End Sub

End Module
