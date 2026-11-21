Imports System.Numerics

Public Class CatalanStrategy
    Implements IIntegerSequenceStrategy

    Public Function CalculateNthTerm(N As UInteger) As BigInteger Implements IIntegerSequenceStrategy.CalculateNthTerm
        Return Catalan(N)
    End Function
End Class
