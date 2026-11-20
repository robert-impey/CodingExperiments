Public Class SquareStrategy
    Implements IIntegerSequenceStrategy

    Public Function CalculateNthTerm(ByVal N As UInteger) As System.Numerics.BigInteger Implements IIntegerSequenceStrategy.CalculateNthTerm
        Return IntegerSequenceFunctions.Square(N)
    End Function
End Class
