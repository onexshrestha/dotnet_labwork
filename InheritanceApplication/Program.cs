using System;
using System.Security.Cryptography.X509Certificates;
namespace InheritanceApplication
{
    //base class
    class Shape
    {
        public void setwidth(int w)
        {
            width = w;

        }
        public void setheight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    //Derived class
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width*height);
        }
    }
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle r= new Rectangle();
            r.setwidth(6);
            r.setheight(4);
            Console.WriteLine("Total Area:{0}",r.getArea());
            Console.ReadKey();
        }
    }

}