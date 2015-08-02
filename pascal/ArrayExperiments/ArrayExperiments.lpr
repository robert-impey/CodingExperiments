program ArrayExperiments;

const
  Max: integer = 10;
var
  A: array of integer;
  I: integer;

begin
  SetLength(A, Max);

  for I := 1 to Max do
  begin
    A[I] := 10 * I;
  end;

  for I := 1 to Max do
  begin
    Write(A[I]);
    if I < Max then
      Write(', ');
  end;

  WriteLn();
end.

