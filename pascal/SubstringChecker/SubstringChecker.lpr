program SubstringChecker;

{$mode objfpc}{$H+}

uses {$IFDEF UNIX} {$IFDEF UseCThreads}
  cthreads, {$ENDIF} {$ENDIF}
  Classes,
  SysUtils,
  CustApp,
  SubstringChecking;

type

  { SubstringChecker }

  TSubstringChecker = class(TCustomApplication)
  protected
    procedure DoRun; override;
  public
    constructor Create(TheOwner: TComponent); override;
    destructor Destroy; override;
    procedure WriteHelp; virtual;
  end;

  { SubstringChecker }

  procedure TSubstringChecker.DoRun;
  var
    ErrorMsg, Haystack, Needle: string;

  begin
    // quick check parameters
    ErrorMsg := CheckOptions('hsn', 'help haystack needle');
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

    if HasOption('s', 'haystack') then
    begin
      Haystack := GetOptionValue('s', 'haystack');
    end
    else
    begin
      WriteHelp;
      Terminate;
      Exit;
    end;

    if HasOption('n', 'needle') then
    begin
      Needle := GetOptionValue('n', 'needle');
    end
    else
    begin
      WriteHelp;
      Terminate;
      Exit;
    end;

    // Program logic
    if Search(Haystack, Needle) then
    begin
      WriteLn('Found!');
    end
    else
    begin
      WriteLn('Not found!');
    end;

    // stop program loop
    Terminate;
  end;

  constructor TSubstringChecker.Create(TheOwner: TComponent);
  begin
    inherited Create(TheOwner);
    StopOnException := True;
  end;

  destructor TSubstringChecker.Destroy;
  begin
    inherited Destroy;
  end;

  procedure TSubstringChecker.WriteHelp;
  begin
    { add your help code here }
    writeln('Usage: ', ExeName, ' -h');
    writeln('Usage: ', ExeName, ' -s "Hay Stack" -n " st"');
  end;

var
  Application: TSubstringChecker;
begin
  Application := TSubstringChecker.Create(nil);
  Application.Title := 'Substring Checker';
  Application.Run;
  Application.Free;
end.
