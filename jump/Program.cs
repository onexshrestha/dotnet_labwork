using System;
int i;


for (i = 1; i < 10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("use of continue");
        continue;
    }
    Console.WriteLine(i);
    if (i == 8) {
        Console.WriteLine("use of break");
        break; }
}

Console.WriteLine("THIS IS JUMP STATEMENT");
