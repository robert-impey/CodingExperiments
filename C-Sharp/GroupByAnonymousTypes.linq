<Query Kind="Statements" />

var name = "Robert";
var dob = DateTime.Parse("1980-10-28");

var name2 = "Robert";
var dob2 = DateTime.Parse("1980-10-28");

Console.WriteLine(name == name2);
Console.WriteLine(name.Equals(name2));

Console.WriteLine(dob == dob2);
Console.WriteLine(dob.Equals(dob2));

var person = new { Name = name, Dob = dob };
var person2 = new { Name = name2, Dob = dob2 };

Console.WriteLine(person == person2);
Console.WriteLine(person.Equals(person2));

var person3 = new { Name = "Robert", Dob = DateTime.Parse("1980-10-31") };

var people = new [] { person, person2, person3 };

foreach (var p in people) {
	Console.WriteLine(p);
}

var counts = people.GroupBy(p => p);

foreach (var c in counts) {
	Console.WriteLine(c);
}

var counts2 = people.GroupBy(p => new { N = p.Name, D = p.Dob });

foreach (var c in counts2) {
	Console.WriteLine(c);
}
