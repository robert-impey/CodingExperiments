<Query Kind="Program" />

void Main()
{
	Print(SmallestPowerOf2);
	Print(SP2Rec);
}

void Print(Func<int, int> calc)
{
	Console.WriteLine(calc(14));
	Console.WriteLine(calc(15));
	Console.WriteLine(calc(16));
	Console.WriteLine(calc(17));
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

int SP2Rec(int x)
{
	int SP2Rec_(int x_)
	{
		if (x_ >= x) return x_;
		return SP2Rec_(x_ * 2);
	}
	
	return SP2Rec_(1);
}
