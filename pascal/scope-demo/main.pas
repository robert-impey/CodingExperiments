Program ScopeDemo;

Var
    A: integer;

    Procedure ScopeInner;
    Var
        A: integer;
    Begin
        A := 10;
        WriteLn(A);
    End;
    
Begin
    A := 20;
    WriteLn(A);
    ScopeInner;
    WriteLn(A);
End.
