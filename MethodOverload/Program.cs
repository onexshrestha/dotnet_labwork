using System;
public class Demo
{
    public static int mulDisplay(int x, int y) {  return x * y; }
    public static int mulDisplay(int x ,int y,int z ) { return x * y * z; }

}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("MULTIPLICATIO OF TWO NUMBERS:" + Demo.mulDisplay(4, 5));
        Console.WriteLine("MULTIPLICATIO OF THREE NUMBERS:" + Demo.mulDisplay(4, 5,6));

    }
}