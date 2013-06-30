Imports System.IO
Imports System.Text.RegularExpressions
Imports MyGrepLib
Imports System.Collections.Specialized

Module MyGrep

    Sub Main()
        Try
            Dim RegEx As String
            Dim FileName As String

            If 0 = My.Application.CommandLineArgs.Count Then
                Usage()
            ElseIf 2 = My.Application.CommandLineArgs.Count Then
                RegEx = My.Application.CommandLineArgs.Item(0)
                FileName = My.Application.CommandLineArgs.Item(1)

                Dim MyLineFinder As LineFinder = New LineFinder(RegEx, FileName)
                Dim MatchingLines As StringCollection = MyLineFinder.GetMatchingLines
                For Each Line As String In MatchingLines
                    Console.WriteLine(Line)
                Next
            Else
                Throw New Exception("Please set the regular expression and the file name!")
            End If

        Catch e As Exception
            Console.Error.WriteLine(e)
        End Try
    End Sub

    Sub Usage()
        Console.WriteLine("Prints the lines of a file that match a regular expression.")
    End Sub

End Module
