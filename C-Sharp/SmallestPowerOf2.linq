<Query Kind="Program" />

void Main()
{
	Console.WriteLine(SmallestPowerOf2(14));
	Console.WriteLine(SmallestPowerOf2(15));
	Console.WriteLine(SmallestPowerOf2(16));
	Console.WriteLine(SmallestPowerOf2(17));
}

int SmallestPowerOf2(int x)
{
	int t = 1;
	
	while (t < x)
	{
		t *= 2;
	}
	
	return t;
}

// You can define other methods, fields, classes and namespaces here
