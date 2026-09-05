using System;
abstract class Shape
{
    public abstract double Area();
}
class Circle : Shape
{
    double radius = 5;

    public override double Area()
    {
        return 3.14 * radius * radius;
    }
}
class Rectangle : Shape
{
    double length = 4, width = 6;

    public override double Area()
    {
        return length * width;
    }
}
class Program
{
    static void Main()
    {
        Shape s1 = new Circle();
        Shape s2 = new Rectangle();

        Console.WriteLine("Circle Area: " + s1.Area());
        Console.WriteLine("Rectangle Area: " + s2.Area());
    }
}
