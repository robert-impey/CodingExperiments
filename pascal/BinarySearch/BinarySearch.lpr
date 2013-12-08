program BinarySearch;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes, SysUtils, CustApp
  { you can add units after this };

type

  { TBinarySearch }

  TBinarySearch = class(TCustomApplication)
  protected
    procedure DoRun; override;
  public
    constructor Create(TheOwner: TComponent); override;
    destructor Destroy; override;
    procedure WriteHelp; virtual;
  end;

{ TBinarySearch }

procedure TBinarySearch.DoRun;
Const
    Max: Integer = 10;
    Sought: Integer = 6;
var
  ErrorMsg: String;
  A: Array [1 .. 10] Of Integer;
  I, J, K: Integer;
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

  For I := 1 To Max Do
      Begin
          A[I] := I;
          WriteLn(A[I]);
      End;

  {Simple Search}
  I := 0;
  Repeat I := I + 1 Until (A[I] = Sought) Or (I = Max);
  If A[I] = Sought Then
      WriteLn('Found!')
  Else
      WriteLn('Not found!');

  {Binary Search}
  I := 1;
  J := Max;
  Repeat K := (I + J) Div 2;
      If Sought > A[K] Then
          I := K + 1
      Else
          J := K - 1
  Until (A[K] = Sought) Or (I > J);

  If (A[K] = Sought) Then
      WriteLn('Found!')
  Else
      WriteLn('Not found!');

  // stop program loop
  Terminate;
end;

constructor TBinarySearch.Create(TheOwner: TComponent);
begin
  inherited Create(TheOwner);
  StopOnException:=True;
end;

destructor TBinarySearch.Destroy;
begin
  inherited Destroy;
end;

procedure TBinarySearch.WriteHelp;
begin
  { add your help code here }
  writeln('Usage: ',ExeName,' -h');
end;

var
  Application: TBinarySearch;
begin
  Application:=TBinarySearch.Create(nil);
  Application.Title:='Binary Search';
  Application.Run;
  Application.Free;
end.

