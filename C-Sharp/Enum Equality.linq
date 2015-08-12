<Query Kind="Program" />

void Main()
{
	var cat = Mammals.Cat;
	
	Console.WriteLine(cat == Mammals.Cat);
	
	Console.WriteLine(Mammals.Cat.Equals(cat));
}

enum Mammals { Cat, Dog, Horse };
