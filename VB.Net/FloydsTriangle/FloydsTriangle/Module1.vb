Module Module1

    Sub Main()
        Dim Rows = 10
        Dim CurrentNumber = 0

        For Row = 1 To Rows
            Dim Columns = Row

            For Column = 1 To Columns
                CurrentNumber += 1
                Console.Write(CurrentNumber & " ")
            Next
            Console.WriteLine()
        Next

    End Sub

End Module
