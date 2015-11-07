using System;

class HelloMsBuild
{
	static void Main()
	{
#if DebugConfig
		Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION");
#endif

		Console.WriteLine("Hello, MsBuild!");
	}
}
