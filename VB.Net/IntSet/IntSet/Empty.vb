Class Empty
    Inherits IntSet
    Overrides Function Incl(ByVal x As Integer) As IntSet
        Return New NonEmpty(x, New Empty, New Empty)
    End Function

    Public Overrides Function ToString() As String
        Return "."
    End Function
End Class
