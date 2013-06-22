Module Module1

    Sub Main()
        Console.WriteLine("Do you go to Wren Academy?")

        Dim wren = Console.ReadLine()

        If wren.ToUpper = "YES" Then
            Console.WriteLine("Which house are you in?")
            Dim house = Console.ReadLine()

            If house.ToUpper.Equals("LUDGATE") Then
                Console.WriteLine("Your head of house is Mr. Fox")
            ElseIf house.ToUpper.Equals("BOW") Then
                Console.WriteLine("Your head of house is Miss Walters")
            Else
                Console.WriteLine("I don't know that house")
            End If
        Else
            Console.WriteLine("That's a shame!")
        End If
    End Sub

End Module
