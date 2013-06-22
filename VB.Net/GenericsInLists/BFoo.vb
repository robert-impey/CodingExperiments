﻿Friend Class BFoo
    Implements IFoo

    Private _bar As Integer

    Friend Sub New(ByVal bar As Integer)
        _bar = bar
    End Sub

    Friend ReadOnly Property Bar As Integer Implements IFoo.Bar
        Get
            Console.WriteLine("In BFoo.Bar getter.")
            Return _bar
        End Get
    End Property
End Class
