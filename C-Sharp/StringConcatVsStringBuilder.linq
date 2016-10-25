<Query Kind="Statements" />

var max = 10;
var runs = 1000;

var stopWatch = new System.Diagnostics.Stopwatch();
var sbTicks = 0L;
var strTicks = 0L;

for (int j = 0; j < runs; j++)
{
	stopWatch.Start();
	var myStringBuilder = new System.Text.StringBuilder();
	for (int i = 0; i < max; i++)
	{
		myStringBuilder.Append("a");
	}
	var stringBuildersString = myStringBuilder.ToString();
	
	stopWatch.Stop();
	sbTicks += stopWatch.ElapsedTicks;

	stopWatch.Reset();
	
	stopWatch.Start();
	
	var myString = String.Empty;
	
	for (int i = 0; i < max; i++)
	{
		myString += "a";
	}
	
	stopWatch.Stop();
	
	strTicks += stopWatch.ElapsedTicks;
}

Console.WriteLine("Average SB: " + (1.0 * sbTicks) / runs);
Console.WriteLine("Average string: " + (1.0  * strTicks) / runs);


