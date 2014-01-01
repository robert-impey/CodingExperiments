program people;

{$mode objfpc}{$H+}

uses {$IFDEF UNIX} {$IFDEF UseCThreads}
  cthreads, {$ENDIF} {$ENDIF}
  Classes,
  SysUtils,
  CustApp { you can add units after this };

type

  { TPeople }

  TPeople = class(TCustomApplication)
  protected
    procedure DoRun; override;
  public
    constructor Create(TheOwner: TComponent); override;
    destructor Destroy; override;
    procedure WriteHelp; virtual;
  end;

  { TPeople }

type
  Person = record
    id: integer;
    Name: string;
    sex: (male, female);
    link: integer;
  end;

Procedure PrintPerson (const person : Person);
begin
  with person do
        begin
          Write(id);
          Write(' ');
          Write(Name);
          Write(' ');
          Write(sex);
          Write(' ');
          Write(link);
          Write(' ');
          WriteLn();
        end;
end;

Function GetSucc (const people : array of Person; const personId1 : integer; const personId2: integer) : Person;
Var
  succId: integer;
  person2 : Person;
Begin
  person2 := people[personId2];
  succId := personId1 + person2.link;
  GetSucc := people[succId];
End;

  procedure TPeople.DoRun;
  const
    n = 10;
  var
    ErrorMsg: string;
    people: array[1..n] of Person;
    i: integer;
    succ : Person;
  begin
    // quick check parameters
    ErrorMsg := CheckOptions('h', 'help');
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

    { See page 20 of A + DS = P by NW }

    with people[1] do
    begin
      id := 1;
      Name := 'Carolyn';
      sex := female;
      link := 2;
    end;
    with people[2] do
    begin
      id := 2;
      Name := 'Chris';
      sex := male;
      link := 2;
    end;
    with people[3] do
    begin
      id := 3;
      Name := 'Tina';
      sex := female;
      link := 5;
    end;
    with people[4] do
    begin
      id := 4;
      Name := 'Robert';
      sex := male;
      link := 3;
    end;
    with people[5] do
    begin
      id := 5;
      Name := 'Jonathan';
      sex := male;
      link := 3;
    end;
    with people[6] do
    begin
      id := 6;
      Name := 'Jennifer';
      sex := female;
      link := 5;
    end;
    with people[7] do
    begin
      id := 7;
      Name := 'Raytheon';
      sex := male;
      link := 5;
    end;
    with people[8] do
    begin
      id := 8;
      Name := 'Mary';
      sex := female;
      link := 3;
    end;
    with people[9] do
    begin
      id := 9;
      Name := 'Anne';
      sex := female;
      link := 1;
    end;
    with people[10] do
    begin
      id := 10;
      Name := 'Mathias';
      sex := male;
      link := 3;
    end;

    for i := 1 to n do PrintPerson(people[i]);

    // Traverse the women
    WriteLn('Traverse the women');

    succ := GetSucc(people, 1, 3);
    PrintPerson(succ);

    // stop program loop
    Terminate;
  end;

  constructor TPeople.Create(TheOwner: TComponent);
  begin
    inherited Create(TheOwner);
    StopOnException := True;
  end;

  destructor TPeople.Destroy;
  begin
    inherited Destroy;
  end;

  procedure TPeople.WriteHelp;
  begin
    { add your help code here }
    writeln('Usage: ', ExeName, ' -h');
  end;

var
  Application: TPeople;
begin
  Application := TPeople.Create(nil);
  Application.Title := 'People';
  Application.Run;
  Application.Free;
end.
