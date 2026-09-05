using System;

class Student
{
    // Private field
    private string name;

    // Property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    static void Main()
    {
        Student s = new Student();
        s.Name = "Onex";
        Console.WriteLine("Name: " + s.Name);
    }
}