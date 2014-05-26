MustInherit Class IntSet
    MustOverride Function Incl(ByVal x As Integer) As IntSet
    MustOverride Function Contains(ByVal x As Integer) As Boolean
    MustOverride Function Union(ByVal other As IntSet) As IntSet
End Class
