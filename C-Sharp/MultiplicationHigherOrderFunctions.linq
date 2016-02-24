<Query Kind="Program" />

void Main()
{
	var doubler = MultiplierMaker(2);
	
	Console.WriteLine(doubler(2));
	
	var tripler = MultiplierMaker(3);
	
	Console.WriteLine(tripler(2));
}

// Define other methods and classes here

static Func<int, int> MultiplierMaker(int mult)
{
	return (x => x * mult);
}