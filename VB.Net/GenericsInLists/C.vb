' This class looks like an IFoo, but it isn't one.

Friend Class C
    Private _bar As Integer

    Friend Sub New(ByVal bar As Integer)
        _bar = bar
    End Sub

    Friend ReadOnly Property Bar As Integer
        Get
            Console.WriteLine("In C.Bar getter.")
            Return _bar
        End Get
    End Property
End Class
