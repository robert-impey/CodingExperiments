program HammingDistance;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX} {$IFDEF UseCThreads}
  cthreads, {$ENDIF} {$ENDIF}
  Classes,
  SysUtils,
  CustApp,
  hammingdistances;

type

  { THammingDistance }

  THammingDistance = class(TCustomApplication)
  protected
    procedure DoRun; override;
  public
    constructor Create(TheOwner: TComponent); override;
    destructor Destroy; override;
    procedure WriteHelp; virtual;
  end;

  { THammingDistance }

  procedure THammingDistance.DoRun;
  var
    ErrorMsg, First, Second: string;
  begin
    // quick check parameters
    ErrorMsg := CheckOptions('hfs', 'help first second');
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

    if HasOption('f', 'first') then
    begin
      First := GetOptionValue('f', 'first');
    end;

    if HasOption('s', 'second') then
    begin
      Second := GetOptionValue('s', 'second');
    end;

    WriteLn(GetHammingDistance(First, Second));

    Terminate;
  end;

  constructor THammingDistance.Create(TheOwner: TComponent);
  begin
    inherited Create(TheOwner);
    StopOnException := True;
  end;

  destructor THammingDistance.Destroy;
  begin
    inherited Destroy;
  end;

  procedure THammingDistance.WriteHelp;
  begin
    { add your help code here }
    writeln('Usage: ', ExeName, ' -h');
  end;

var
  Application: THammingDistance;
begin
  Application := THammingDistance.Create(nil);
  Application.Title := 'Hamming Distance';
  Application.Run;
  Application.Free;
end.
