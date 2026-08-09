using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public  class IO
    {
        public static void first()
        {
            Console.WriteLine("Input output operations:");
            student s = new student();
            Console.Write("Enter your Name:");
            s.name = Console.ReadLine();
            Console.Write("Enter your Roll no:");
            s.roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Students Details are:");
            Console.WriteLine("Name:"+s.name);
            Console.WriteLine("Roll no:"+s.roll);




        }

            
    }
}
