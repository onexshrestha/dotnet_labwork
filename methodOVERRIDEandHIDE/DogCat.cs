using System;
using System.Collections.Generic;
using System.Text;

namespace methodOVERRIDEandHIDE
{
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("OVERRIDE!");
            Console.WriteLine("Dog barks");
        }
    }
    public class Cat : Animal { 
public new void Eat()
        {
            Console.WriteLine("OVERHIDE!");
            Console.WriteLine("Cat eats fish");
        }
    }

}
