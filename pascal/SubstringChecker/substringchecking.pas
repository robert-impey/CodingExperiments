unit SubstringChecking;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils;

function Search(Haystack, Needle: string): boolean;

implementation

function Search(Haystack, Needle: string): boolean;
var
  HaystackIndex, NeedleIndex: integer;
  Found: boolean;
begin
  HaystackIndex := 1;
  Found := False;

  if (Length(Haystack) >= Length(Needle)) and (Length(Needle) > 0) then
  begin
    while (HaystackIndex <= Length(Haystack)) and (not Found) do
    begin
      NeedleIndex := 1;
      while (Haystack[HaystackIndex + NeedleIndex - 1] = Needle[NeedleIndex]) and
        (not Found) do
      begin
        if NeedleIndex = Length(Needle) then
        begin
          Found := True;
        end
        else
        begin
          Inc(NeedleIndex);
        end;
      end;
      Inc(HaystackIndex);
    end;
  end;
  Result := Found;
end;

end.
