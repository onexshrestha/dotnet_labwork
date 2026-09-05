using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    public class CatchALL
    {
        public static void Main()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured! by CATCH ALL");
            }
            finally { Console.WriteLine("finally block!"); }
            Console.WriteLine($"Result is {div}");
        }
    }
}
