using System;

namespace SW_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Multiply");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                n = int.Parse(Console.ReadLine());

                if (n == 3)
                {
                    Console.WriteLine("Program exited.");
                    break;
                }

                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Addition = " + (a + b));
                        break;

                    case 2:
                        Console.WriteLine("Multiplication = " + (a * b));
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (true);

            Console.ReadLine();
        }
    }
}