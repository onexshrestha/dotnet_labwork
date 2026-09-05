using System;
using System.Collections;
namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al= new ArrayList();
            Console.WriteLine("Adding some numbers:");
            al.Add(1);
            al.Add(4);
            al.Add(34);
            Console.WriteLine("Capacity:{0}",al.Capacity);
            Console.WriteLine("Count:{0}",al.Count);
            foreach(int i in al) Console.WriteLine(i+" ");
        }
    }
}