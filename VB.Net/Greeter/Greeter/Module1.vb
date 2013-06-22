Module Module1

    Sub Main()
        Console.WriteLine("What's your name?")

        Dim name = Console.ReadLine()

        Console.WriteLine("Hello, " & name)

        If name.StartsWith("R") Then
            Console.WriteLine("Your name starts with the letter 'R'")
        Else
            Console.WriteLine("Your name starts with another letter.")
        End If

        Console.WriteLine("What's your age?")
        Dim ageStr = Console.ReadLine()

        Dim age As Integer

        If Integer.TryParse(ageStr, age) Then
            Console.WriteLine("You're at least " & (age * 12) & " months old.")
        Else
            Console.WriteLine("That's not a number.")
        End If
    End Sub

End Module
