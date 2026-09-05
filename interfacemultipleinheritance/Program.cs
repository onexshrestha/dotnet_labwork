using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
namespace Interfacemultipleinheritance
{
    //base class
    class Shape
    {
        public void Setwidth(int w)
        {
            width = w;

        }
        public void Setheight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    public interface PaintCost
    {
        int getCost(int area);
    }
    //Derived class
    class Rectangle : Shape,PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 80;
        }
    }
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Setwidth(6);
            r.Setheight(4);
            int area= r.getArea();
            Console.WriteLine("Total Area:{0}", r.getArea());
            Console.WriteLine("Total Paint cost:${0}", r.getCost(area));

            Console.ReadKey();
        }
    }

}