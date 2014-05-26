Class NonEmpty
    Inherits IntSet
    Private elem As Integer
    Private left, right As IntSet

    Sub New(ByVal elem As Integer, ByVal left As IntSet, ByVal right As IntSet)
        Me.elem = elem
        Me.left = left
        Me.right = right
    End Sub

    Overrides Function Incl(ByVal x As Integer) As IntSet
        If x < elem Then
            Return New NonEmpty(elem, left.Incl(x), right)
        ElseIf x > elem Then
            Return New NonEmpty(elem, left, right.Incl(x))
        Else
            Return Me
        End If
    End Function

    Overrides Function Contains(x As Integer) As Boolean
        If x < elem Then
            Return left.Contains(x)
        ElseIf x > elem Then
            Return right.Contains(x)
        Else
            Return True
        End If
    End Function

    Public Overrides Function Union(other As IntSet) As IntSet
        Return left.Union(right).Union(other).Incl(elem)
    End Function

    Public Overrides Function ToString() As String
        Return "{" & left.ToString() & elem & right.ToString() & "}"
    End Function
End Class
