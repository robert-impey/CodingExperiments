// See p. 139 of
// Power Maths Year 3
// Practice Book 3B

var danny = 2.0;
var dannyStep = 1.0 / 4.0;

var aki = 4.0;
var akiStep = 1.0 / 8.0;

var steps = 0;

while (danny <= aki)
{
    PrintState();

    danny += dannyStep;
    aki -= akiStep;

    steps++;
}

Console.WriteLine("They have passed each other.");

PrintState();

void PrintState()
{
    Console.WriteLine($"After {steps} steps Danny is at {danny} and Aki is at {aki}.");
}
