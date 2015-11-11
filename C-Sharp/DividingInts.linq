<Query Kind="Statements" />

int a = 1;
int b = 2;

double c = a / b;

Console.WriteLine("c: " + c);

double d = (double)a / (double)b;
double e = a / (double)b;
double f = (double)a / b;
double g = (a + 0.0) / b;
double h = a / (b + 0.0);

Console.WriteLine("d: " + d);
Console.WriteLine("e: " + e);
Console.WriteLine("f: " + f);
Console.WriteLine("g: " + g);
Console.WriteLine("h: " + h);
