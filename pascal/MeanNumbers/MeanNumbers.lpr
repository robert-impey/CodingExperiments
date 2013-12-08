program MeanNumbers;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes, SysUtils, CustApp
  { you can add units after this };

type

  { TMeanNumbers }

  TMeanNumbers = class(TCustomApplication)
  protected
    procedure DoRun; override;
  public
    constructor Create(TheOwner: TComponent); override;
    destructor Destroy; override;
    procedure WriteHelp; virtual;
  end;

{ TMeanNumbers }

procedure TMeanNumbers.DoRun;
Const
    NumberOfNumbers: integer = 5;
var
  ErrorMsg: String;
  Number1, Number2, Number3, Number4, Number5, Sum: integer;
  Mean: real;
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

  Number1 := 45;
  Number2 := 7;
  Number3 := 68;
  Number4 := 2;
  Number5 := 34;

  Sum := Number1 + Number2 + Number3 + Number4 + Number5;

  Mean := Sum / NumberOfNumbers;

  (* Output *)
  WriteLn('Number of numbers: ', NumberOfNumbers);

  WriteLn('Number 1: ', Number1);
  WriteLn('Number 2: ', Number2);
  WriteLn('Number 3: ', Number3);
  WriteLn('Number 4: ', Number4);
  WriteLn('Number 5: ', Number5);

  WriteLn('Mean: ', Mean);

  // stop program loop
  Terminate;
end;

constructor TMeanNumbers.Create(TheOwner: TComponent);
begin
  inherited Create(TheOwner);
  StopOnException:=True;
end;

destructor TMeanNumbers.Destroy;
begin
  inherited Destroy;
end;

procedure TMeanNumbers.WriteHelp;
begin
  { add your help code here }
  writeln('Usage: ',ExeName,' -h');
end;

var
  Application: TMeanNumbers;

begin
  Application:=TMeanNumbers.Create(nil);
  Application.Title:='Mean Numbers';
  Application.Run;
  Application.Free;
end.

