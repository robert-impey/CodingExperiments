Program DivInequalities;

Const
    M: integer = 11;
    N: integer = 5;
    
Begin
    WriteLn('M: ', M);
    WriteLn('N: ', N);
    
    WriteLn('M - N: ', M - N);
    
    WriteLn('M div N: ', M div N);
    WriteLn('(M div N) * N: ', (M div N) * N);
    
    WriteLn('M mod N: ', M mod N);
    WriteLn('(M div N) * N + M mod N: ', (M div N) * N + M mod N);
End.
