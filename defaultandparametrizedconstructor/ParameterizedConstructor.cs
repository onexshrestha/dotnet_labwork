using System;
using System.Collections.Generic;
using System.Text;

namespace defaultandparametrizedconstructor
{
    public class ParameterizedConstructor
    {
        public int Id;
        public string Name;
         public ParameterizedConstructor(int id, string name)
        {
            Id= id;
            Name= name;
        }
        public void Display()
        {
            Console.WriteLine("Parametrized constructor called");
            Console.WriteLine("ID=",+Id);
            Console.WriteLine("Name="+Name);
        }

    }
}
