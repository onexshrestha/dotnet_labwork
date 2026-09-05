using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_case
{
    internal class foreac
    {
        static void Main(string[] args)
        {
            string[] players = { "Messi", "Ronaldo","Neymar","Ronaldinho","Haaland" };
            Console.WriteLine("The players are:");
            foreach (string x in players)
            {
                Console.WriteLine(x);
            }
        }
    }
}
