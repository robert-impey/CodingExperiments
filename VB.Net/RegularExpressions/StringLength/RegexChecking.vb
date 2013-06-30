Imports System.Text.RegularExpressions

Class RegexChecking
    Inherits RangeCheckingFunction

    Public Sub New(ByRef TestString As String, ByRef MinLength As Integer, ByRef MaxLength As Integer)
        MyBase.New(TestString, MinLength, MaxLength)
        _Name = "Regex"
    End Sub

    Public Overrides Function InRange() As Boolean
        Dim rgx As Regex = New Regex("^.{" & _MinLength & "," & _MaxLength & "}$")

        Return rgx.IsMatch(_TestString)
    End Function
End Class
