<Query Kind="Program" />

void Main()
{
	var x = 2;
	
	if (x > 1 && x < 5)
	{
		Console.WriteLine("Passes");
	}
	
	if (Test(x))
	{
		Console.WriteLine("Passes");
	}	
}

static bool Test(int x)
{
	return x > 1 && x < 5;
}
	