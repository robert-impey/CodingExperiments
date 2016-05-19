Module Module1

    Sub Main()
        Dim fruits =
                <?xml version="1.0"?>
                <fruits>
                    <fruit>Apple</fruit>
                    <fruit>Banana</fruit>
                    <fruit>Coconut</fruit>
                </fruits>

        For Each fruit In fruits.Element("fruits").Elements()
            Console.WriteLine(fruit.Value)
        Next

    End Sub

End Module
