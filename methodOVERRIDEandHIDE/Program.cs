using methodOVERRIDEandHIDE;
using System;
class Program
{
    static void Main()
    {
        Dog d= new Dog();
        d.Sound();
        Animal an = new Dog();
        Console.Write(" Child class ");
        an.Sound();
        Cat c= new Cat();
        c.Eat();
        Animal a= new Cat();
        Console.WriteLine(" Child class hide but not override  ");
        a.Eat();


    }
}