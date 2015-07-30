program BinarySearch;

{$mode objfpc}{$H+}

uses {$IFDEF UNIX} {$IFDEF UseCThreads}
  cthreads, {$ENDIF} {$ENDIF}
  Classes,
  SysUtils,
  CustApp { you can add units after this };

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
  var
    ErrorMsg, SearchMethod: string;
    A: array of integer;
    Sought, Max, I, J, K: integer;
    Verbose, Found: boolean;

  begin
    // quick check parameters
    ErrorMsg := CheckOptions('hsmvr', 'help sought max verbose search');
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

    if HasOption('s', 'sought') then
    begin
      Sought := StrToInt((GetOptionValue('s', 'sought')));
    end
    else
    begin
      WriteHelp;
      Terminate;
      Exit;
    end;

    if HasOption('m', 'max') then
    begin
      Max := StrToInt((GetOptionValue('m', 'max')));
    end
    else
    begin
      WriteHelp;
      Terminate;
      Exit;
    end;

    Verbose := HasOption('v', 'verbose');

    if HasOption('r', 'search') then
    begin
      SearchMethod := (GetOptionValue('r', 'search'));
    end
    else
    begin
      WriteHelp;
      Terminate;
      Exit;
    end;

    SetLength(A, Max);
    for I := 1 to Max do
    begin
      A[I] := I;
    end;

    if Verbose then
    begin
      Write('Sought: ');
      WriteLn(Sought);

      Write('Max: ');
      WriteLn(Max);

      Write('A: ');
      for I := 1 to Max do
      begin
        Write(A[I]);
        if I < Max then
          Write(', ');
      end;
      WriteLn();

      Write('Search Method: ');
      WriteLn(SearchMethod);
    end;

    // Searching

    if SearchMethod = 'sequential' then
    begin
      if Verbose then Write('Using Sequential Search... ');
      I := 0;

      repeat
        I := I + 1
      until (A[I] = Sought) or (I = Max);

      Found := A[I] = Sought;
    end
    else if SearchMethod = 'binary' then
    begin
      if Verbose then Write('Using Binary Search... ');
      I := 1;
      J := Max;

      repeat
        K := (I + J) div 2;
        if Sought > A[K] then
          I := K + 1
        else
          J := K - 1
      until (A[K] = Sought) or (I > J);

      Found := A[K] = Sought;
    end
    else if SearchMethod = 'sentinel' then
    begin
      if Verbose then Write('Using Sequential Search with Sentinel... ');
      SetLength(A, Max + 1);
      A[Max + 1] := Sought;
      I := 1;

      repeat
        I := I + 1
      until (A[I] = Sought);

      Found := I = Max + 1;
    end
    else
    begin
      WriteLn('Unknown search method!');
      Terminate;
      Exit;
    end;

    if Found then
      WriteLn('Found!')
    else
      WriteLn('Not found!');

    // stop program loop
    Terminate;
  end;

  constructor TBinarySearch.Create(TheOwner: TComponent);
  begin
    inherited Create(TheOwner);
    StopOnException := True;
  end;

  destructor TBinarySearch.Destroy;
  begin
    inherited Destroy;
  end;

  procedure TBinarySearch.WriteHelp;
  begin
    writeln('Usage: ', ExeName, ' -h');
    WriteLn('Options');
    WriteLn('-s|--sought [INT]');
    WriteLn('-m|--max [INT]');
    WriteLn('-v|--verbose');
    WriteLn('r|--search');
  end;

var
  Application: TBinarySearch;
begin
  Application := TBinarySearch.Create(nil);
  Application.Title := 'Binary Search';
  Application.Run;
  Application.Free;
end.
