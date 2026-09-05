using System;
public partial class Coords
{
    private int x;
    private int y;
    public Coords(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
public partial class Coords
{
    public void PrintCoords()
    {
        Console.WriteLine("Coords are: {0},{1}",x,y);
    }
}
class Progroam
{
    static void Main()
    {
        Coords c = new Coords(10, 20);
        c.PrintCoords();
    }
}
