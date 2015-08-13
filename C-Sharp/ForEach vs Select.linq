<Query Kind="Statements" />

var xs = new List<System.Int32>() { 1, 2, 3 };

IList<int> ys;

ys = new List<int>();
foreach (var x in xs)
{
	ys.Add(x * 2);
}

//ys = xs.Select(x => x * 2).ToList();

foreach (var y in ys)
{
	Console.WriteLine(y);
}
