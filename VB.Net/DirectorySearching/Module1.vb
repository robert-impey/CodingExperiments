Imports System.IO

Module Module1

    Sub Main()
        If My.Application.CommandLineArgs.Count <> 2 Then
            Console.WriteLine("Please tell me the directory to search and the pattern to match!")
        Else
            Dim dir As String = My.Application.CommandLineArgs(0)
            Dim pattern As String = My.Application.CommandLineArgs(1)

            Dim searchResults As String() = Directory.GetFiles(dir, pattern, SearchOption.AllDirectories)

            For Each searchResult In searchResults
                Console.WriteLine(searchResult)
            Next
        End If
    End Sub

End Module
