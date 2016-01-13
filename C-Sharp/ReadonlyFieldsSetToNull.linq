<Query Kind="Program" />

void Main()
{	
	var foo = new Foo("Foo");
	Console.WriteLine(foo.Bar);
	
	var nullFoo = new Foo(null);
	Console.WriteLine(nullFoo.Bar);
}

public class Foo
{
	private readonly string bar;
	private readonly string neverSet; // Warnings because it's never used.
	
	public Foo(string bar)
	{
		this.bar = bar;
	}
	
	public string Bar
	{
		get
		{
			return this.bar;
		}
	}
}