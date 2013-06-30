Imports System.Numerics

Public Class Context
    Private Strategy As IIntegerSequenceStrategy

    Sub New(ByRef Strategy As IIntegerSequenceStrategy)
        Me.Strategy = Strategy
    End Sub

    Function ExecuteStrategy(ByVal N As UInteger) As BigInteger
        Return Strategy.CalculateNthTerm(N)
    End Function
End Class
