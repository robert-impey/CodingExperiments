program power;

const
  n = 10;
type
  digit = 0..9;
var
  i, k, r: integer;
  d: array [1..n] of digit;
begin
  { See page 15 of
    Algorithms + Data Structures = Programs
    by Nicklaus Wirth }

  for k := 1 to n do
  begin
    Write('.');
    r := 0;
    for i := 1 to k - 1 do
    begin
      r := 10 * r + d[i];
      d[i] := r div 2;
      r := r - 2 * d[i];
      Write(d[i]);
    end;
    d[k] := 5;
    WriteLn(5);
  end;
end.