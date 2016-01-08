<Query Kind="Statements" />

var xs = new [] { 1, 2, 3 };

Console.WriteLine("Filtering the xs with the Func<T, bool>");
Func<int, bool> funcPred = x => x > 1;

var filteredFuncXs = xs.Where(funcPred);

foreach (var x in filteredFuncXs)
{
	Console.WriteLine(x);
}

Console.WriteLine("Using Predicate<T> in a foreach loop");
Predicate<int> pred = x => x > 1;

foreach (var x in xs)
{
	if (pred(x))
	{
		Console.WriteLine(x);
	}
}

// There's no overload that accepts Predicate<T>
// http://stackoverflow.com/questions/665494/why-funct-bool-instead-of-predicatet
// The following line won't compile.
//var filteredPredXs = xs.Where(pred);
