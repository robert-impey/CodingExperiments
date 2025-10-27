var input = "abc*$%123";

var alphaNum = input.Where(c => char.IsLetter(c) || char.IsNumber(c) ).ToArray();

var nonAlphaNum = input.Where(c => !char.IsLetter(c) && !char.IsNumber(c)).ToArray();

Console.WriteLine($"Alphanumeric characters: {new string(alphaNum)}");
Console.WriteLine($"Non-alphanumeric characters: {new string(nonAlphaNum)}");
