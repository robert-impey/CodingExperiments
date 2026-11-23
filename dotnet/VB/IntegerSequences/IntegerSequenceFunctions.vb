Imports System.Numerics

Module IntegerSequenceFunctions
    Function Factorial(N As UInteger) As BigInteger
        If 1 = N Then
            Return N
        Else
            Return N * Factorial(N - 1)
        End If
    End Function

    Function Fibonacci(N As UInteger) As BigInteger
        If 1 = N Then
            Return 0
        ElseIf 2 = N Then
            Return 1
        Else
            Return Fibonacci(N - 1) + Fibonacci(N - 2)
        End If
    End Function

    Function Square(N As UInteger) As BigInteger
        Return N * N
    End Function

    Function Catalan(N As UInteger) As BigInteger
        Return Factorial(2 * N) / (Factorial(N) * Factorial(N + 1))
    End Function
End Module
