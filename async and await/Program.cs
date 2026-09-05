using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Task Started...");

        await DoWork();

        Console.WriteLine("Task Completed.");

        Console.ReadLine();
    }

    static async Task DoWork()
    {
        Console.WriteLine("Working...");

        // Wait for 3 seconds without blocking
        await Task.Delay(3000);

        Console.WriteLine("Work Finished.");
    }
}