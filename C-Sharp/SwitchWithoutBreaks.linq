<Query Kind="Statements" />

var value = 3;

switch (value)
{
	case 1:
		Console.WriteLine("It's 1!");
	case 2:
	case 3:
		Console.WriteLine("It's 2 or 3!");
		break;
	default:
		Console.WriteLine("It's something else!");
		break;
}

