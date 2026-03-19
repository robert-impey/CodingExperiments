program FindEquilibriumIndex;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}
  cthreads,
  {$ENDIF}
  SysUtils,
  Classes;

  function FindEquilibriumIndex(const a: array of integer): integer;
  var
    sum, left, right: int64;
    i: integer;
    found: boolean;
    idx: integer;
    Count: integer;
  begin
    Count := Length(a);

    sum := 0;
    for i := 0 to Count - 1 do
      sum := sum + a[i];

    left := 0;
    right := sum;
    found := False;
    idx := -1;

    i := 0;
    while (i < Count) and (not found) do
    begin
      right := right - a[i];

      if left = right then
      begin
        found := True;
        idx := i;
      end
      else
        left := left + a[i];

      Inc(i);
    end;

    Result := idx;
  end;

var
  Lines: TStringList;
  Numbers: array of integer;
  i: integer;
begin
  if ParamCount < 1 then
  begin
    WriteLn('Usage: FindEquilibriumIndex <filename>');
    Halt(1);
  end;

  Lines := TStringList.Create;
  try
    Lines.LoadFromFile(ParamStr(1));
    Numbers := nil;

    SetLength(Numbers, Lines.Count);

    for i := 0 to Lines.Count - 1 do
    begin
      try
        Numbers[i] := StrToInt(Trim(Lines[i]));
      except
        on E: EConvertError do
        begin
          WriteLn('Error on line ', i + 1, ': "', Lines[i], '" is not a valid integer.');
          Halt(1);
        end;
      end;
    end;

    WriteLn(FindEquilibriumIndex(Numbers));
  finally
    Lines.Free;
  end;
end.
