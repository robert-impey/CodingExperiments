<Query Kind="Statements" />

string[] strings = new string[5];

object[] objects;

objects = new object[1];
objects[0] = new Int32(); // No problem

objects = strings;
objects[0] = new Int32(); // Run time exception