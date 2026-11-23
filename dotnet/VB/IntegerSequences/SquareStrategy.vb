Imports System.Numerics

Public Class SquareStrategy
    Implements IIntegerSequenceStrategy

    Public Function CalculateNthTerm(N As UInteger) As BigInteger Implements IIntegerSequenceStrategy.CalculateNthTerm
        Return Square(N)
    End Function
End Class
