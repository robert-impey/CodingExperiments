﻿Public Class FactorialStrategy
    Implements IIntegerSequenceStrategy

    Public Function CalculateNthTerm(ByVal N As UInteger) As System.Numerics.BigInteger Implements IIntegerSequenceStrategy.CalculateNthTerm
        Return IntegerSequenceFunctions.Factorial(N)
    End Function
End Class
