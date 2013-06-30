/**
 * Short program to look at the Liskov Substitution Principle
 * 
 * http://en.wikipedia.org/wiki/Liskov_substitution_principle
 * 
 * RFI 2011-06-22
 */

using System;
using System.Collections.Generic;

namespace LspPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            people.Add(new Person { Name = "Adam" });
            people.Add(new Person { Name = "Barry" });

            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine("-----");

            var charles = new PersonWithAge { Name = "Charles", Age = 25 };
            Console.WriteLine(string.Format("Name: {0}\tAge: {1}", charles.Name, charles.Age));
            Console.WriteLine("-----");

            people.Add(charles);
            foreach (var person in people)
            {
                Console.WriteLine(person.Name); // Every object that is a "Person" or of a type that is a subtype of "Person" has a "Name".
            }
            Console.WriteLine("-----");

            var dave = new PersonWithDateOfBirth { Name = "Dave", DateOfBirth = new DateTime(1989, 12, 15) };
            Console.WriteLine(string.Format("Name: {0}\tAge: {1}", dave.Name, dave.Age));
            Console.WriteLine("-----");

            var peopleWithAges = new List<PersonWithAge>();
            peopleWithAges.Add(charles);
            peopleWithAges.Add(dave);

            // We can access the age of all these objects correctly despite the different implementations.
            foreach (var personWithAge in peopleWithAges)
            {
                Console.WriteLine(string.Format("Name: {0}\tAge: {1}", personWithAge.Name, personWithAge.Age));
            }
            Console.WriteLine("-----");

            // However, we will get a run time error if we set the age of these objects.
            foreach (var personWithAge in peopleWithAges)
            {
                //personWithAge.Age++; // This will cause an exception to be thrown!
            }

            var peopleWithAgesV2 = new List<PersonWithAgeV2>();
            peopleWithAgesV2.Add(new PersonWithAgeFromYearsV2 { Name = "Eddy", YearsOld = 36 });
            peopleWithAgesV2.Add(new PersonWithDateOfBirthV2 { Name = "Frank", DateOfBirth = new DateTime(1998, 5, 23) });

            foreach (var personWithAge in peopleWithAgesV2)
            {
                Console.WriteLine(string.Format("Name: {0}\tAge: {1}", personWithAge.Name, personWithAge.Age));
                //personWithAge.Age++; // This causes a compile time error because we didn't define the "setter" for this property.
            }
        }
    }
}
