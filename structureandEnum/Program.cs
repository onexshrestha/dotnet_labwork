using System;
struct Books
{
    public string Title;
    public int B_id;

};
public class testStructure
{
    public static void Main()
    {
        Books Book1;
        Books Book2;
        Book1.Title = "Net Centric";
        Book1.B_id = 378;

        Book2.Title = "E-commerce";
        Book2.B_id = 383;

        Console.WriteLine("BOOK1 TITLE : {0}",Book1.Title);
        Console.WriteLine("BOOK1 ID: {0}", Book1.B_id);
        Console.WriteLine("BOOK2 TITLE : {0}", Book2.Title);
        Console.WriteLine("BOOK2 ID : {0}", Book2.B_id);

    }
}
