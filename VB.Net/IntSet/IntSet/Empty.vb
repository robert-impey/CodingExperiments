Class Empty
    Inherits IntSet
    Overrides Function Incl(ByVal x As Integer) As IntSet
        Return New NonEmpty(x, New Empty, New Empty)
    End Function

    Overrides Function Contains(x As Integer) As Boolean
        Return False
    End Function

    Public Overrides Function Union(other As IntSet) As IntSet
        Return other
    End Function

    Public Overrides Function ToString() As String
        Return "."
    End Function
End Class
