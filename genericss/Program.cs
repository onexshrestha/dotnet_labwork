using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a dictionary
        Dictionary<int, string> students = new Dictionary<int, string>();

        // Add key-value pairs
        students.Add(101, "Ram");
        students.Add(102, "Sita");
        students.Add(103, "Hari");

        // Display all items
        Console.WriteLine("Student List:");
        foreach (KeyValuePair<int, string> item in students)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        // Access a value using its key
        Console.WriteLine("\nStudent with Roll No. 102: " + students[102]);

        Console.ReadLine();
    }
}