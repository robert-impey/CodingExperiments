var data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (var i = 1; i < data.Count; i++)
{
    Console.WriteLine($"{data[i]} - {data[i-1]} = {data[i] - data[i - 1]}");
}
