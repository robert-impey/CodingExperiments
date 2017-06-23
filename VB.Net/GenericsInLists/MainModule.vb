' To show the use of Generics in Lists
'
' See: http://msdn.microsoft.com/en-us/library/w256ka79(v=VS.100).aspx
'
' RFI 2011-06-14

Module MainModule

    Sub Main()
        Dim someFoos As IList(Of IFoo) = New List(Of IFoo)

        someFoos.Add(New AFoo(1))
        someFoos.Add(New BFoo(2))
        'someFoos.Add(New C(3)) ' We can't add this object to the list.
        'someFoos.Add(CType(New C(3), IFoo)) ' This causes an invalid cast exception to be thrown at runtime

        For Each foo As IFoo In someFoos
            Dim fooBar As Integer = foo.Bar ' We know at compile time that the object has this property and that it returns an integer.
            Console.WriteLine(String.Format("fooBar: {0}", fooBar))
        Next

        Dim aFooHolder As FooHolder(Of AFoo) = New FooHolder(Of AFoo)(New AFoo(4))
        Dim fooBarFromAFooHolder As Integer = aFooHolder.Foo.Bar ' We know at compile time that this is an integer.
        'aFooHolder.Foo = New BFoo(5) ' We can't set this property to this.

        'Dim bFooHolder As FooHolder(Of BFoo) = New FooHolder(Of BFoo)(New AFoo(5))  ' We can't give an AFoo to a holder of a BFoo.
        ' However, this compiles in MonoDevelop on a Mac.
        'Dim fooBarFromBFooHolder As Integer = bFooHolder.Foo.Bar
        'Console.WriteLine(String.Format("fooBarFromBFooHolder: {0}", fooBarFromBFooHolder))

        'Dim cHolder As FooHolder(Of C) = New FooHolder(Of C)(New C(6)) ' Even though the types match, this holder is constrained to IFoos.
    End Sub

End Module