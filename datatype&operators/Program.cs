using System;
int a = 5;
int  b= 3;
Console.WriteLine("a="+a);
Console.WriteLine("b="+b);
int d = 36;
const int c = 0;
int sum = a + b;
int product = a * b;
Console.WriteLine("The sum is :"+ sum);
Console.WriteLine("The product is :" + product);
if(a>b)
{
    Console.WriteLine("a is greater");
}
else
{
    Console.WriteLine("b is greater");
}

d/= b;
Console.WriteLine(d);

string x, y;
Console.Write("Enter a number :");
x= Console.ReadLine();
Console.Write("Enter second number:");
y= Console.ReadLine();
Console.WriteLine("The String numbers sum is :"+ (Convert.ToInt32 (x) + Convert.ToInt32(y)));
Console.WriteLine("\nBitwise Operations:");

Console.WriteLine("a & b = " + (a & b));   // AND
Console.WriteLine("a | b = " + (a | b));   // OR
Console.WriteLine("a ^ b = " + (a ^ b));   // XOR
Console.WriteLine("~a = " + (~a));         // NOT
Console.WriteLine("a << 1 = " + (a << 1)); // Left Shift
Console.WriteLine("a >> 1 = " + (a >> 1)); // Right Shift

Console.ReadKey();



