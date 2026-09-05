using System;
public class Animal
{
    public void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
public class Dog : Animal
{
    public void Sound()
    {
     
        Console.WriteLine("Dog Barks");
    }
    public void Test()
    {
        Sound();
        base.Sound();
    }
}
public class Test
{
    static void Main()
    {
        Dog d= new Dog();
        d.Test();
    }
}