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
    ErrorMsg: string;
    A: array of integer;
    Sought, Max, I, J, K: integer;
  begin
    // quick check parameters
    ErrorMsg := CheckOptions('hsm', 'help sought max');
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
      Write('Looking for ');
      WriteLn(Sought);
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
      Write('Max value ');
      WriteLn(Max);
    end
    else
    begin
      WriteHelp;
      Terminate;
      Exit;
    end;

    SetLength(A, Max);

    for I := 0 to Max - 1 do
      A[I] := I + 1;

    // Searching
    WriteLn('Sequential Search');
    I := -1;

    repeat
      I := I + 1
    until (A[I] = Sought) or (I = Max);

    if A[I] = Sought then
      WriteLn('Found!')
    else
      WriteLn('Not found!');

    WriteLn('Binary Search');
    I := 0;
    J := Max - 1;

    repeat
      K := (I + J) div 2;
      if Sought > A[K] then
        I := K + 1
      else
        J := K - 1
    until (A[K] = Sought) or (I > J);

    if A[K] = Sought then
      WriteLn('Found!')
    else
      WriteLn('Not found!');

    WriteLn('Sequential Search with Sentinel');
    SetLength(A, Max + 1);
    A[Max] := Sought;
    I := -1;

    repeat
      I := I + 1
    until (A[I] = Sought);

    if I = Max then
      WriteLn('Not found!')
    else
      WriteLn('Found!');

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
  end;

var
  Application: TBinarySearch;
begin
  Application := TBinarySearch.Create(nil);
  Application.Title := 'Binary Search';
  Application.Run;
  Application.Free;
end.
