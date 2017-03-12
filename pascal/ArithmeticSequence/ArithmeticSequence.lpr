program ArithmeticSequence;

{$mode objfpc}{$H+}

uses {$IFDEF UNIX} {$IFDEF UseCThreads}
  cthreads, {$ENDIF} {$ENDIF}
  Classes,
  SysUtils,
  CustApp,
  arithmeticsequences { you can add units after this };

type

  { TArithmeticSequence }

  TArithmeticSequence = class(TCustomApplication)
  protected
    procedure DoRun; override;
  public
    constructor Create(TheOwner: TComponent); override;
    destructor Destroy; override;
    procedure WriteHelp; virtual;
  end;

  { TArithmeticSequence }

  procedure TArithmeticSequence.DoRun;
  var
    ErrorMsg: string;
    A, D, N, Index: integer;
    Terms: array of integer;
  begin
    // quick check parameters
    ErrorMsg := CheckOptions('hadn', 'help start difference count');
    if ErrorMsg <> '' then
    begin
      ShowException(Exception.Create(ErrorMsg));
      Terminate;
      Exit;
    end;

    // parse parameters
    if HasOption('h', 'help') then
    begin
      WriteHelp;
      Terminate;
      Exit;
    end;

    if HasOption('a', 'start') then
    begin
      A := StrToInt(GetOptionValue('a', 'start'));
    end
    else
    begin
      A := 1;
    end;

    if HasOption('d', 'difference') then
    begin
      D := StrToInt(GetOptionValue('d', 'difference'));
    end
    else
    begin
      D := 1;
    end;

    if HasOption('n', 'count') then
    begin
      N := StrToInt(GetOptionValue('n', 'count'));
    end
    else
    begin
      n := 10;
    end;

    Terms := GetTerms(A, D, N);

    for Index := 0 to N - 1 do
    begin
      Write(Terms[Index]);

      if Index <> N - 1 then
      begin
        Write(', ');
      end;
    end;
    WriteLn();

    // stop program loop
    Terminate;
  end;

  constructor TArithmeticSequence.Create(TheOwner: TComponent);
  begin
    inherited Create(TheOwner);
    StopOnException := True;
  end;

  destructor TArithmeticSequence.Destroy;
  begin
    inherited Destroy;
  end;

  procedure TArithmeticSequence.WriteHelp;
  begin
    { add your help code here }
    writeln('Usage: ', ExeName, ' -h');
  end;

var
  Application: TArithmeticSequence;
begin
  Application := TArithmeticSequence.Create(nil);
  Application.Title := 'Arithmetic Sequence';
  Application.Run;
  Application.Free;
end.
