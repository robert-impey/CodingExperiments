<Query Kind="Statements" />

Console.Write("foo   ".Trim());
Console.WriteLine("|");

Console.Write("foo///".Trim(new char[] { '/'}));
Console.WriteLine("|");

Console.Write("foo/\\/\\/\\/\\/".Trim(new char[] { '/', '\\'}));
Console.WriteLine("|");

