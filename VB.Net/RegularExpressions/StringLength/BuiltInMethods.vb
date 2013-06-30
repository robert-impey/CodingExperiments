Class BuiltInMethods
    Inherits RangeCheckingFunction

    Public Sub New(ByRef TestString As String, ByRef MinLength As Integer, ByRef MaxLength As Integer)
        MyBase.New(TestString, MinLength, MaxLength)
        _Name = "Built in Methods"
    End Sub

    Public Overrides Function InRange() As Boolean
        Return _TestString.Length >= _MinLength AndAlso _TestString.Length <= _MaxLength
    End Function
End Class
