Module Module1

    Sub Main()
        Hello10()
        Console.WriteLine()
        ManyHellos(20)
        Console.WriteLine()
        Console.WriteLine(Doubler(10))
        Console.WriteLine()
        Greeter("Mr. Impey")
        Console.WriteLine()
        Console.WriteLine(Multiplier(2, 4))
    End Sub

    Sub Hello10()
        For counter = 1 To 10
            Console.WriteLine("Hello!")
        Next
    End Sub

    Sub ManyHellos(ByVal times As Integer)
        For counter = 1 To times
            Console.WriteLine("Hello!")
        Next
    End Sub

    Function Doubler(ByVal input As Integer) As Integer
        Return 2 * input
    End Function

    Sub Greeter(ByVal name As String)
        Console.WriteLine("Hello, " & name)
    End Sub

    Function Multiplier(ByVal input1 As Integer, ByVal input2 As Integer) As Integer
        Return input1 * input2
    End Function
End Module
