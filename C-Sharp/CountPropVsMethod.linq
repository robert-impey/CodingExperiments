<Query Kind="Statements" />

// See:
// Enumerable.Count https://msdn.microsoft.com/en-us/library/vstudio/bb338038%28v=vs.110%29.aspx
// ICollection<T>.Count https://msdn.microsoft.com/en-us/library/vstudio/5s3kzhec%28v=vs.110%29.aspx
// List<T>.Count https://msdn.microsoft.com/en-us/library/27b47ht3%28v=vs.110%29.aspx

// Count simply gets the property - O(1)
// Count() causes a called to Enumerable.Count, which checks if the IEnumerable
// is a ICollection. In this case, it is, so the same Count property is called.

// Both methods have the same algorithmic complexity, but the second way has a few more
// steps.

var xs = new List<System.Int32>() { 1, 2, 3, 4, 5 };

Console.WriteLine(xs.Count);
Console.WriteLine(xs.Count());
