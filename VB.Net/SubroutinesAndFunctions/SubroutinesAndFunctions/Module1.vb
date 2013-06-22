Module Module1
    Sub Main()
        Numbers(10)
        Numbers(20)

        Dim sum = SumUpTo(10)
        Console.WriteLine(sum)
    End Sub
    Function SumUpTo(ByVal max As Integer) As Integer
        Dim sum = 0

        For counter = 1 To max
            sum += counter
        Next

        Return sum
    End Function
    Sub Numbers(ByVal max As Integer)
        For counter = 1 To max
            Console.WriteLine(counter)
        Next
    End Sub
End Module
