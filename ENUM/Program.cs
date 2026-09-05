using System;
using System.Threading.Channels;
enum Days { Sunday, Monday, Tuesday, Wednesday , Thursday, Friday,Saturday};
class Enumapp
{
   
    static void Main(string[] args)
    {
        Days today = Days.Thursday;
 
        Console.WriteLine("Today is "+ today);
        Console.WriteLine("Value of Today is "+ (int)today);
        foreach (Days d in Enum.GetValues(typeof(Days))) {
            Console.WriteLine(d+"="+(int)d); 
        }

    }
}