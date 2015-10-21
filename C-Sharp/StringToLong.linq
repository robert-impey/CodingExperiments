<Query Kind="Program" />

void Main()
{
	var inputs = new[]{
		"1234",
		"",
		"12.34",
		"One Two Three Four"
	};
	
	foreach (var input in inputs)
	{
		var output = ConvertToInt64(input);
		if (output == null)
		{
			Console.WriteLine("Nothing found!");
		}
		else
		{
			Console.WriteLine(output.Value);
		}
	}
}

// Define other methods and classes here
static long? ConvertToInt64(string metric)
{
	long outVal;
    if (Int64.TryParse(metric, out outVal))
    {
      return outVal;
    }
    return null;
}
