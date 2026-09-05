using System;

class Student
{
    // Array to store marks
    private int[] marks = new int[5];

    // Indexer
    public int this[int index]
    {
        get
        {
            return marks[index];
        }
        set
        {
            marks[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        // Assign values using indexer
        s[0] = 85;
        s[1] = 90;
        s[2] = 78;
        s[3] = 88;
        s[4] = 95;

        // Display values using indexer
        Console.WriteLine("Student Marks:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + ": " + s[i]);
        }

        Console.ReadLine();
    }
}