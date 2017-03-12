unit arithmeticsequences;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils;

type
  IntArray = array of integer;

function GetTerms(A, D, N: integer): IntArray;

implementation

function GetTerms(A, D, N: integer): IntArray;
var
  CurrentTerm, Index: integer;
  Terms: IntArray;
begin
  SetLength(Terms, N);

  CurrentTerm := A;

  for Index := 0 to N - 1 do
  begin
    Terms[Index] := CurrentTerm;
    CurrentTerm := CurrentTerm + D;
  end;

  Result := Terms;
end;

end.
