using System;
sealed class Student
{
    public Student()
    {
        Console.WriteLine("Student is obedient");
    }
}
class Clzstudent : Student
{
    public Clzstudent()
    {
        Console.WriteLine("I am college student");
    }
}
class Program
{
    static void Main()
    {
        Student s= new Student();
    }
}
