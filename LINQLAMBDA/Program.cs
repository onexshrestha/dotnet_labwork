using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 25, 30, 45, 50, 60 };

        // Lambda Expression
        var result = numbers.Where(x => x > 30);

        Console.WriteLine("Numbers greater than 30:");
        foreach (int num in result)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}