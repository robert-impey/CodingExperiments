Public Class Form1

    Private Sub encryptButton_Click(sender As System.Object, e As System.EventArgs) Handles encryptButton.Click
        Dim plainText = inputTextBox.Text

        Dim cipherText = ""

        For Each letter In plainText
            Dim code = Asc(letter)
            Dim nextLetterCode = code + 1
            cipherText = cipherText & Chr(nextLetterCode)
        Next

        outputTextBox.Text = cipherText
    End Sub
End Class
