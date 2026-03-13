program FindEquilibriumIndex;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}
  cthreads,
  {$ENDIF}
  SysUtils, Classes;

var
  Lines: TStringList;
  Numbers: array of Integer;
  i: Integer;
begin
  if ParamCount < 1 then
  begin
    WriteLn('Usage: FindEquilibriumIndex <filename>');
    Halt(1);
  end;

  Lines := TStringList.Create;
  try
    Lines.LoadFromFile(ParamStr(1));

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

  finally
    Lines.Free;
  end;

  for i := 0 to High(Numbers) do
    WriteLn('Numbers[', i, '] = ', Numbers[i]);
end.

