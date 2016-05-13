<Query Kind="Statements" />

var beatles = new Dictionary<string, string>();

beatles["John"] = "singer";
beatles["Ringo"] = "drum player";
beatles["Paul"] = "bass player";
beatles["George"] = "guitarist";

Console.WriteLine("----");

foreach (var beatleName in beatles.Keys)
{
	Console.WriteLine("{0} is a {1}.", beatleName, beatles[beatleName]);
}

Console.WriteLine("----");

foreach (var beatleName in beatles.Keys.ToList())
{
	Console.WriteLine("{0} is a {1}.", beatleName, beatles[beatleName]);
}