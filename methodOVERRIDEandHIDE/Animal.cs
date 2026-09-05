using System;
using System.Collections.Generic;
using System.Text;

namespace methodOVERRIDEandHIDE
{
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes sound");
        }
        public void Eat()
        {
            Console.WriteLine("Animal eats food");
        }
    }
}
