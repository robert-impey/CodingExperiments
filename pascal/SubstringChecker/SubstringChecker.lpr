program SubstringChecker;

{$mode objfpc}{$H+}

uses {$IFDEF UNIX} {$IFDEF UseCThreads}
  cthreads, {$ENDIF} {$ENDIF}
  Classes,
  SysUtils,
  CustApp { you can add units after this };

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
    Found: boolean;

    procedure Search;
    var
      HaystackIndex, NeedleIndex: integer;
    begin
      HaystackIndex := 0;
      Found := False;

      if (Length(Haystack) >= Length(Needle)) and (Length(Needle) > 0) then
      begin
        while (HaystackIndex <= Length(Haystack)) and (not Found) do
        begin
          Inc(HaystackIndex);
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
        end;
      end;
    end;

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
    Search;
    if Found then
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
