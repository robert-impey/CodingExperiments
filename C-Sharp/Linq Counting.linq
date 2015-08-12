<Query Kind="Statements" />

var xs = new List<System.Int32>() { 1, 2, 3, 4, 5 };

int numMoreThan2;

numMoreThan2 = xs.Count(x => x > 2);
Console.WriteLine(numMoreThan2);

var moreThan2Enum = xs.Where(x => x > 2);

// Won't compile
//numMoreThan2 = moreThan2Enum.Count;

var moreThan2List = moreThan2Enum.ToList();

numMoreThan2 = moreThan2List.Count;
Console.WriteLine(numMoreThan2);

