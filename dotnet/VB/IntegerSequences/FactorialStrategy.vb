Imports System.Numerics

Public Class FactorialStrategy
    Implements IIntegerSequenceStrategy

    Public Function CalculateNthTerm(N As UInteger) As BigInteger Implements IIntegerSequenceStrategy.CalculateNthTerm
        Return Factorial(N)
    End Function
End Class
