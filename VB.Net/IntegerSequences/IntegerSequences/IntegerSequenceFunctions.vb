Imports System.Numerics

Module IntegerSequenceFunctions
    Function Factorial(ByVal N As UInteger) As BigInteger
        If 1 = N Then
            Return N
        Else
            Return N * Factorial(CUInt(N - 1))
        End If
    End Function

    Function Fibonacci(ByVal N As UInteger) As BigInteger
        If 1 = N Then
            Return 0
        ElseIf 2 = N Then
            Return 1
        Else
            Return Fibonacci(CUInt(N - 1)) + Fibonacci(CUInt(N - 2))
        End If
    End Function

    Function Square(ByVal N As UInteger) As BigInteger
        Return N * N
    End Function

    Function Catalan(ByVal N As UInteger) As BigInteger
        Return Factorial(CUInt(2 * N)) / (Factorial(N) * Factorial(CUInt(N + 1)))
    End Function
End Module
