// See Page 30 of "Linear Algebra for Dummies"
// Calculate the magnitude of a vector.

var xs = new[] { 3.0, 2.0, 4.0 };

var sum = xs.Sum(x => x * x);

var mag = Math.Sqrt(sum);

Console.WriteLine(mag);

// Sum of Vectors (page 28)
var a = new[] { 2.0, 4.0};
var b = new[] { 3.0, 1.0};

var sumOfAAndB = new double[a.Length];

for (var i = 0; i < a.Length; i++)
{
    sumOfAAndB[i] += a[i] + b[i];
}

foreach (var element in sumOfAAndB)
{
    Console.WriteLine(element);
}

// Dot product of two vectors (page 37)

var u = new [] { 4.0, -2.0, 0.0, 1.0};
var v = new [] {-1.0, -3.0, 1.0, 5 };

var dotProduct = 0.0;

for (var i = 0; i < u.Length; i++)
{
    dotProduct += u[i] * v[i];
}

Console.WriteLine(dotProduct);
