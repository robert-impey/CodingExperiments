Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Collections
Imports System.Collections.Specialized

Public Class LineFinder
    Private _RegEx As Regex
    Private _FileName As String

    Public Sub New(ByVal RegEx As String, ByVal FileName As String)
        _RegEx = New Regex(RegEx)
        _FileName = FileName
    End Sub

    Function GetMatchingLines() As StringCollection
        Dim MatchingLines As StringCollection = New StringCollection

        Dim FileStreamReader As StreamReader = New StreamReader(_FileName)

        Dim Line As String
        Do While FileStreamReader.Peek() <> -1
            Line = FileStreamReader.ReadLine()

            If _RegEx.IsMatch(Line) Then
                MatchingLines.Add(Line)
            End If
        Loop

        Return MatchingLines
    End Function
End Class
