Module MyCat

    Sub Main(ByVal Args As String())
        If 0 = Args.Length Then
            Console.WriteLine("Please give me a file!")
        ElseIf Args.Length > 1 Then
            Console.WriteLine("Just one file at a time, please!")
        Else
            Dim FileName As String = Args(0)

            Dim MyReader As System.IO.StreamReader
            MyReader = System.IO.File.OpenText(FileName)

            While MyReader.Peek <> -1
                Console.WriteLine(MyReader.ReadLine())
            End While

            MyReader.Close()
        End If
    End Sub

End Module
