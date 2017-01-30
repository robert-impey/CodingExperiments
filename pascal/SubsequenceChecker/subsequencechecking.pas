unit SubsequenceChecking;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils;

function ContainsSubsequence(Haystack, Needle: string): boolean;

implementation

function ContainsSubsequence(Haystack, Needle: string): boolean;
var
  NeedleIndex, HaystackIndex, NeedleLength, HaystackLength: integer;
begin
  Result := False;
  NeedleLength := Length(Needle);
  HaystackLength := Length(Haystack);

  if (NeedleLength > 0) and (HaystackLength > NeedleLength) then
  begin
    NeedleIndex := 1;
    HaystackIndex := 1;

    while (NeedleIndex <= NeedleLength) and (HaystackIndex <= HaystackLength) do
    begin
      if Needle[NeedleIndex] = Haystack[HaystackIndex] then
      begin
        Inc(NeedleIndex);
      end;
      Inc(HaystackIndex);
    end;

    Result := NeedleLength = NeedleIndex - 1;
  end;
end;

end.
