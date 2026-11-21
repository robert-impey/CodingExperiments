Imports System.Numerics

Public Class FibonacciStrategy
    Implements IIntegerSequenceStrategy

    Public Function CalculateNthTerm(N As UInteger) As BigInteger Implements IIntegerSequenceStrategy.CalculateNthTerm
        Return Fibonacci(N)
    End Function
End Class
