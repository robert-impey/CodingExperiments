program power;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes, SysUtils, CustApp
  { you can add units after this };

type

  { TPower }

  TPower = class(TCustomApplication)
  protected
    procedure DoRun; override;
  public
    constructor Create(TheOwner: TComponent); override;
    destructor Destroy; override;
    procedure WriteHelp; virtual;
  end;

{ TPower }

procedure TPower.DoRun;
const n = 10;
type digit = 0..9;
var
  ErrorMsg: String;
  i, k, r: integer;
  d: array [1..n] of digit;
begin
  // quick check parameters
  ErrorMsg:=CheckOptions('h','help');
  if ErrorMsg<>'' then begin
    ShowException(Exception.Create(ErrorMsg));
    Terminate;
    Exit;
  end;

  // parse parameters
  if HasOption('h','help') then begin
    WriteHelp;
    Terminate;
    Exit;
  end;

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

  // stop program loop
  Terminate;
end;

constructor TPower.Create(TheOwner: TComponent);
begin
  inherited Create(TheOwner);
  StopOnException:=True;
end;

destructor TPower.Destroy;
begin
  inherited Destroy;
end;

procedure TPower.WriteHelp;
begin
  { add your help code here }
  writeln('Usage: ',ExeName,' -h');
end;

var
  Application: TPower;
begin
  Application:=TPower.Create(nil);
  Application.Title:='Power';
  Application.Run;
  Application.Free;
end.

