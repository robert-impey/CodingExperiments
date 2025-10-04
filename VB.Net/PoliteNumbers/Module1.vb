' https://en.wikipedia.org/wiki/Polite_number
' A polite number is a positive integer that can be expressed as the sum of two or more consecutive positive integers.

Module Module1

    Sub Main()
        Try
            Dim numConsecutiveIntegers As Integer
            Dim max As Integer

            If 0 = My.Application.CommandLineArgs.Count Then
                numConsecutiveIntegers = 2
                max = 10
            ElseIf 2 = My.Application.CommandLineArgs.Count Then
                Dim argNumConsecutiveIntegers As String = My.Application.CommandLineArgs(0)
                If Integer.TryParse(argNumConsecutiveIntegers, numConsecutiveIntegers) Then
                    If numConsecutiveIntegers < 2 Then
                        Throw New Exception("The number of consecutive integers must be 2 or greater!")
                    End If
                Else
                    Throw New Exception("The number of consecutive integers must be an integer!")
                End If

                Dim argMax As String = My.Application.CommandLineArgs(1)
                If Integer.TryParse(argMax, max) Then
                    If max < 1 Then
                        Throw New Exception("The max must be 1 or greater!")
                    End If
                Else
                    Throw New Exception("The max must be an integer!")
                End If
            Else
                Throw New Exception("Please set just the number of consecutive integers and the maximum!")
            End If

            PrintSumsOfConsecutiveIntegers(numConsecutiveIntegers, max)
        Catch ex As Exception
            Console.Error.WriteLine(ex)
        End Try
    End Sub

    Sub PrintSumsOfConsecutiveIntegers(ByVal numberOfConsecutiveIntegers As Integer, ByVal max As Integer)
        Dim sum, currentInteger As Integer
        For currentStart = 1 To max
            sum = 0
            For addend = 0 To numberOfConsecutiveIntegers - 1
                If addend > 0 Then
                    Console.Write(" + ")
                End If

                currentInteger = currentStart + addend
                sum += currentInteger

                Console.Write(currentInteger)
            Next
            Console.WriteLine(" = " & sum)
        Next
    End Sub
End Module
