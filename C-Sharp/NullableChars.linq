<Query Kind="Program" />

void Main()
{
	char myChar;

	myChar = 'A';
	//myChar = null;

	char? myNullableChar = null;
	
	WriteNullableChar(myChar);
	WriteNullableChar(null);
	WriteNullableChar(myNullableChar);
}

static void WriteNullableChar(char? myNullableChar)
{
	if (myNullableChar.HasValue)
	{
		Console.WriteLine(myNullableChar);
	}
	else
	{
		Console.WriteLine("Feed me!");
	}
}