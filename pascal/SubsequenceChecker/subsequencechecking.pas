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

  if (NeedleLength > 0) and (HaystackLength > 0) then
  begin
    NeedleIndex := 0;
    HaystackIndex := 0;

    while (NeedleIndex < NeedleLength) and (HaystackIndex < HaystackLength) do
    begin
      if Needle[NeedleIndex] = Haystack[HaystackIndex] then
      begin
        NeedleIndex := NeedleIndex + 1;
      end;
      HaystackIndex := HaystackIndex + 1;
    end;

    Result := NeedleLength = NeedleIndex;
  end;
end;

end.
