using System;
using System.Collections.Generic;
using System.Text;

namespace defaultandparametrizedconstructor
{
    public class Defaultconstructor
    {
        public int id;
        public string Name;
        public Defaultconstructor()
        {
            id = 1;
            Name = "Onex";

        }
        public void Display()
        {
            Console.WriteLine("Default constructor called");
            Console.WriteLine("ID=" + id);
            Console.WriteLine("Name=" + Name);
        }

    }
   
}
