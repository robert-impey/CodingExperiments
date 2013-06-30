Program BinarySearch;

Const
    Max: Integer = 10;
    Sought: Integer = 4;
    
Var
    A: Array [1 .. Max] Of Integer;
    I, J, K: Integer;
    
Begin
    For I := 1 To Max Do
        Begin
            A[I] := I;
            WriteLn(A[I]);
        End;
    
    {Simple Search}
    I := 0;
    Repeat I := I + 1 Until (A[I] = Sought) Or (I = Max);
    If A[I] = Sought Then
        WriteLn('Found!')
    Else
        WriteLn('Not found!');
    
    {Binary Search}
    I := 1;
    J := Max;
    Repeat K := (I + J) Div 2;
        If Sought > A[K] Then
            I := K + 1
        Else
            J := K - 1
    Until (A[K] = Sought) Or (I > J);
    
    If (A[K] = Sought) Then
        WriteLn('Found!')
    Else
        WriteLn('Not found!');
End.
