using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "student.txt";

        // Write data to file
        StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine("Roll No: 32");
        writer.WriteLine("Name: onex");
        writer.WriteLine("Faculty: BSC CSIT");
        writer.Close();

        Console.WriteLine("Data written to file successfully.");

        // Read data from file
        StreamReader reader = new StreamReader(filePath);

        Console.WriteLine("\nData from file:");
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        reader.Close();

        Console.ReadLine();
    }
}