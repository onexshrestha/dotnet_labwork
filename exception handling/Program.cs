using System;
class CatchoneException
{
    public static void Main()
    {
        int x = 0;
        int div = 0;
        int[] n = { 1, 2, 3 };
        try
        {
            Console.WriteLine(n[4]);
            div = 100 / x;
            Console.WriteLine("Not executed line!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Exception occured! by divide by zero");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range exception occured");
        }
        finally { Console.WriteLine("finally block!"); }
        Console.WriteLine($"Result is {div}");
    }
}
