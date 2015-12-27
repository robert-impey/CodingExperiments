program SubsequenceChecker;

{$mode objfpc}{$H+}

uses {$IFDEF UNIX} {$IFDEF UseCThreads}
  cthreads, {$ENDIF} {$ENDIF}
  Classes,
  SysUtils,
  CustApp,
  SubsequenceChecking;

type

  { TSubsequenceChecker }

  TSubsequenceChecker = class(TCustomApplication)
  protected
    procedure DoRun; override;
  public
    constructor Create(TheOwner: TComponent); override;
    destructor Destroy; override;
    procedure WriteHelp; virtual;
  end;

  { TSubsequenceChecker }

  procedure TSubsequenceChecker.DoRun;
  var
    ErrorMsg, Haystack, Needle: string;
  begin
    // quick check parameters
    ErrorMsg := CheckOptions('h s n', 'help haystack needle');
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
    end;

    if HasOption('n', 'needle') then
    begin
      Needle := GetOptionValue('n', 'needle');
    end;

    if ContainsSubsequence(haystack, needle) then
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

  constructor TSubsequenceChecker.Create(TheOwner: TComponent);
  begin
    inherited Create(TheOwner);
    StopOnException := True;
  end;

  destructor TSubsequenceChecker.Destroy;
  begin
    inherited Destroy;
  end;

  procedure TSubsequenceChecker.WriteHelp;
  begin
    { add your help code here }
    writeln('Usage: ', ExeName, ' -h');
  end;

var
  Application: TSubsequenceChecker;
begin
  Application := TSubsequenceChecker.Create(nil);
  Application.Title := 'Subsequence Checker';
  Application.Run;
  Application.Free;
end.
