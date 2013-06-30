Imports System.Numerics

Module Main
    Sub Main()
        Try
            Dim Sequence As String

            If 0 = My.Application.CommandLineArgs.Count Then
                Usage()
            ElseIf 2 = My.Application.CommandLineArgs.Count Then
                Sequence = My.Application.CommandLineArgs.Item(0)

                Dim Max As Integer
                If Integer.TryParse(My.Application.CommandLineArgs.Item(1), Max) Then
                    If Max < 1 Then
                        Throw New Exception("The maximum must be 1 or greater!")
                    End If
                Else
                    Throw New Exception("The maximum must be a number!")
                End If

                PrintSequence(Sequence, CUInt(Max))
            Else
                Throw New Exception("Please set the sequence and the maximum!")
            End If

        Catch e As Exception
            Console.Error.WriteLine(e)
        End Try
    End Sub

    ' Printing Functions
    Sub Usage()
        Console.WriteLine("Sequences.exe [SEQUENCE] [MAX]")
    End Sub

    Sub PrintSequence(ByVal Sequence As String, ByVal Max As UInteger)
        Sequence = Sequence.ToLower

        Dim Stategy As IIntegerSequenceStrategy
        Select Case Sequence
            Case "square"
                Stategy = New SquareStrategy()
            Case "factorial"
                Stategy = New FactorialStrategy()
            Case "fibonacci"
                Stategy = New FibonacciStrategy()
            Case "catalan"
                Stategy = New CatalanStrategy()
            Case Else
                Throw New Exception("Unimplemented sequence!")
        End Select

        Dim Context As Context = New Context(Stategy)

        For Index As UInteger = 1 To Max
            Console.Write(Context.ExecuteStrategy(Index))
            Console.Write(" ")
        Next
        Console.WriteLine()
    End Sub
End Module
