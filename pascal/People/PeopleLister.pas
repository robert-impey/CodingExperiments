program PeopleLister;

type
  Person = record
    id: integer;
    Name: string;
    sex: (male, female);
    link: integer;
  end;

  procedure PrintPerson(const person: Person);
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

  function GetPersonById(const people: array of Person; const id: integer): Person;
  begin
    GetPersonById := people[id - 1];
  end;

  function GetSucc(const people: array of Person; const predId: integer;
  const currId: integer): Person;
  var
    succId: integer;
    curr: Person;
  begin
    curr := GetPersonById(people, currId);
    succId := predId + curr.link;
    GetSucc := GetPersonById(people, succId);
  end;

  function GetPred(const people: array of Person; const succId: integer;
  const currId: integer): Person;
  var
    predId: integer;
    curr: Person;
  begin
    curr := GetPersonById(people, currId);
    predId := succId - curr.link;
    GetPred := GetPersonById(people, predId);
  end;

const
  n = 10;
var

  people: array[1..n] of Person;
  i, Count: integer;
  pred, curr, succ: Person;
begin
  { See Section 1.7 of A + DS = P by NW }

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

  WriteLn('Print the people');
  for i := 1 to n do
    PrintPerson(people[i]);

  WriteLn('Count the women');
  Count := 0;
  for i := 1 to n do
    with people[i] do
      if sex = female then
        Count := Count + 1;
  Write('There are ');
  Write(Count);
  WriteLn(' women.');

  WriteLn('Traverse the women');

  pred := GetPersonById(people, 1);
  curr := GetPersonById(people, 3);
  succ := GetSucc(people, pred.id, curr.id);
  PrintPerson(succ);

  pred := curr;
  curr := succ;
  succ := GetSucc(people, pred.id, curr.id);
  PrintPerson(succ);

  pred := curr;
  curr := succ;
  succ := GetSucc(people, pred.id, curr.id);
  PrintPerson(succ);

  WriteLn('Traverse the men backwards');
  succ := GetPersonById(people, 10);
  curr := GetPersonById(people, 7);
  pred := GetPred(people, succ.id, curr.id);
  PrintPerson(pred);

  succ := curr;
  curr := pred;
  pred := GetPred(people, succ.id, curr.id);
  PrintPerson(pred);

  succ := curr;
  curr := pred;
  pred := GetPred(people, succ.id, curr.id);
  PrintPerson(pred);
end.