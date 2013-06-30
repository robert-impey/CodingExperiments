Imports System.Text

Module StringLength

    Sub Main()
        Dim LongStringLength, ShortStringLength, ValidStringLength, MinLength, MaxLength As Integer

        LongStringLength = 10000
        ShortStringLength = 100
        ValidStringLength = 200

        MinLength = 150
        MaxLength = 300

        Dim LongString As String = BuildTestString(LongStringLength)
        Dim ShortString As String = BuildTestString(ShortStringLength)
        Dim ValidString As String = BuildTestString(ValidStringLength)

        Dim RangeCheckingFunctions As List(Of RangeCheckingFunction) = New List(Of RangeCheckingFunction)

        RangeCheckingFunctions.Add(New BuiltInMethods(LongString, MinLength, MaxLength))
        RangeCheckingFunctions.Add(New RegexChecking(LongString, MinLength, MaxLength))
        RangeCheckingFunctions.Add(New BuiltInMethods(ShortString, MinLength, MaxLength))
        RangeCheckingFunctions.Add(New RegexChecking(ShortString, MinLength, MaxLength))
        RangeCheckingFunctions.Add(New BuiltInMethods(ValidString, MinLength, MaxLength))
        RangeCheckingFunctions.Add(New RegexChecking(ValidString, MinLength, MaxLength))

        RangeCheckingFunctions.ForEach(AddressOf TestRangeCheckingFunction)
    End Sub

    Private Function BuildTestString(ByVal TestStringLength As Integer) As String
        Dim TestStringBuilder As StringBuilder = New StringBuilder

        Dim I As Integer
        For I = 0 To TestStringLength - 1
            TestStringBuilder.Append("a")
        Next

        Return TestStringBuilder.ToString
    End Function

    Private Sub TestRangeCheckingFunction(ByVal RangeCheckingFunction As RangeCheckingFunction)
        Console.WriteLine("Testing: " & RangeCheckingFunction.Name)
        If RangeCheckingFunction.InRange Then
            Console.WriteLine("The LongString is in range.")
        Else
            Console.WriteLine("The LongString is out of range.")
        End If
    End Sub
End Module
