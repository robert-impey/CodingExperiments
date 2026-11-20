Public Class CatalanStrategy
    Implements IIntegerSequenceStrategy

    Public Function CalculateNthTerm(ByVal N As UInteger) As System.Numerics.BigInteger Implements IIntegerSequenceStrategy.CalculateNthTerm
        Return IntegerSequenceFunctions.Catalan(N)
    End Function
End Class
