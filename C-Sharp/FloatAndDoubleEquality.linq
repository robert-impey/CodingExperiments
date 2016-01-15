<Query Kind="Statements" />

float f = 6f / 13f;

double d = 6.0 / 13.0;

Console.WriteLine("f: " + f);
Console.WriteLine("d: " + d);

Console.WriteLine("Are equal? " + (f == d));

var fString = f.ToString();
Console.WriteLine("fString " + fString);
var fLength = fString.Length;
Console.WriteLine(fLength);
var dString = d.ToString();
Console.WriteLine(dString.Length);

var dSubstring = dString.Substring(0, fLength - 1);
Console.WriteLine("dSubstring " + dSubstring);

var dLastSinglePrecisionDigitString = dString.Substring(fLength - 1, 1);
Console.WriteLine("dLastSinglePrecisionDigitString " + dLastSinglePrecisionDigitString);

var nextDigitString = dString.Substring(fLength, 1);
Console.WriteLine("nextDigitString " + nextDigitString);

int dLastSinglePrecisionDigit, nextDigit;
if (int.TryParse(dLastSinglePrecisionDigitString, out dLastSinglePrecisionDigit) && int.TryParse(nextDigitString, out nextDigit))
{
	if (nextDigit >= 5)
	{
		dLastSinglePrecisionDigit++; // What about when this is 9?
	}
	
	dSubstring += dLastSinglePrecisionDigit;
	Console.WriteLine("dSubstring " + dSubstring);
	Console.WriteLine("Are equal? " + fString.Equals(dSubstring));
}