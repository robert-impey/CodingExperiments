Module Program
    Sub Main()
        Dim code = Asc("A")
        Console.WriteLine(code)

        Console.WriteLine(Chr(112))

        Dim nextLetter = Chr(code + 1)
        Console.WriteLine(nextLetter)
        Console.WriteLine()

        Dim plainText = "James Bond"

        For Each letter In plainText
            Console.WriteLine(Asc(letter))
        Next

        Console.WriteLine()

        Dim cipherText = Encrypt(plainText)

        Console.WriteLine(cipherText)
    End Sub

    Function Encrypt(plainText As String) As String
        Dim cipherText = ""

        For Each letter In plainText
            Dim code = Asc(letter)
            Dim nextLetterCode = code + 1
            cipherText &= Chr(nextLetterCode)
        Next

        Return cipherText
    End Function
End Module
