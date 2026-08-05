MustInherit Class RangeCheckingFunction
    Protected _Name As String

    Protected _TestString As String
    Protected _MinLength As Integer
    Protected _MaxLength As Integer

    Public Sub New(ByRef TestString As String, ByRef MinLength As Integer, ByRef MaxLength As Integer)
        _TestString = TestString
        _MinLength = MinLength
        _MaxLength = MaxLength
    End Sub

    Public ReadOnly Property Name() As String
        Get
            Return _Name
        End Get
    End Property

    Public MustOverride Function InRange() As Boolean
End Class
