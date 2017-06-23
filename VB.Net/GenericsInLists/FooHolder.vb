Friend Class FooHolder(Of T As {IFoo, Class})
    Private _foo As T

    Friend Sub New(ByRef foo As T)
        _foo = foo
    End Sub

    Friend Property Foo As T
        Get
            Return _foo
        End Get
        Set(ByVal value As T)
            _foo = value
        End Set
    End Property

End Class