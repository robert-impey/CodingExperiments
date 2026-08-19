Module Program
    Sub Main()
        Dim myBln As Boolean = True
        Dim myInt As Integer = 10

        Dim myVar = myBln * myInt 'If option strict is 'Off'.
        'Dim myVar = CInt(myBln) * myInt 'If option strict is 'On'.

        Console.WriteLine(myVar)

        myBln = False
        myVar = myBln * myInt

        Console.WriteLine(myVar)
    End Sub
End Module
