<Query Kind="Statements" />

// https://msdn.microsoft.com/en-us/library/b1csw23d(v=vs.110).aspx

string[] strs = new[] { "apples", "bananas", "coconuts" };
object[] objs = strs;

var fmt = "First: {0}, Second: {1}, Third: {2}";

Console.WriteLine(string.Format(fmt, strs));
Console.WriteLine(string.Format(fmt, objs));

var shortFmt = "First: {0}, Second: {1}";
Console.WriteLine(string.Format(shortFmt, strs)); // No problem

var longFmt = "First: {0}, Second: {1}, Third: {2}, Fourth: {3}";
Console.WriteLine(string.Format(longFmt, strs)); // FormatException
