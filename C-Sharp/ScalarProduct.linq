<Query Kind="Statements" />

var xs = new [] { 1, 2, 3 };
var ys = new [] { 6, 7, 8, 9 };

var sum = 0;

foreach (var x in xs)
{
	foreach (var y in ys)
	{
		sum += x * y;
	}
}

Console.WriteLine(sum);

var linqSum = 
	(from x in xs
	from y in ys
	select x * y).Sum();
	
Console.WriteLine(linqSum);