Program MeanNumbers;

Const
    NumberOfNumbers: integer = 5;

Var
    Number1, Number2, Number3, Number4, Number5, Sum: integer;
    Mean: real;
    
Begin
    Number1 := 45;
    Number2 := 7;
    Number3 := 68;
    Number4 := 2;
    Number5 := 34;
    
    Sum := Number1 + Number2 + Number3 + Number4 + Number5;
    
    Mean := Sum / NumberOfNumbers;
    
    (* Output *)
    WriteLn('Number of numbers: ', NumberOfNumbers);

    WriteLn('Number 1: ', Number1);
    WriteLn('Number 2: ', Number2);
    WriteLn('Number 3: ', Number3);
    WriteLn('Number 4: ', Number4);
    WriteLn('Number 5: ', Number5);
    
    WriteLn('Mean: ', Mean);
End.
