// See Page 30 of "Linear Algebra for Dummies"
// Calculate the magnitude of a vector.

var xs = new[] { 3.0, 2.0, 4.0 };

var sum = xs.Sum(x => x * x);

var mag = Math.Sqrt(sum);

Console.WriteLine(mag);