unit hammingdistances;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils;

function GetHammingDistance(First, Second: string): integer;

implementation

function GetHammingDistance(First, Second: string): integer;
var
  index, distance: integer;
begin
  if (Length(First) = Length(Second)) and (Length(First) > 0) then
  begin
    distance := 0;

    for Index := 1 to Length(First) do
    begin
      if First[Index] <> Second[Index] then
        Inc(distance);
    end;

  end
  else
    distance := -1;

  Result := distance;
end;

end.
