Module Main
    Sub Main()
        Try
            Dim Min As Integer = 1
            Dim Max As Integer

            If 0 = My.Application.CommandLineArgs.Count Then
                Max = 10
            ElseIf 1 = My.Application.CommandLineArgs.Count Then
                Dim ArgMax As String = My.Application.CommandLineArgs.First
                If Integer.TryParse(ArgMax, Max) Then
                    If Max < 1 Then
                        Throw New Exception("The maximum must be 1 or greater!")
                    End If
                Else
                    Throw New Exception("The maximum must be a number!")
                End If

            Else
                Throw New Exception("Please set just the maximum!")
            End If

            For index = 1 To Max
                Console.WriteLine(Square(index))
            Next
        Catch e As Exception
            Console.Error.WriteLine(e)
        End Try
    End Sub

    Function Square(number As Integer) As Integer
        Return number * number
    End Function
End Module
