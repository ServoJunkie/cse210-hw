using System;

class Program
{
    static void Main(string[] args)
    {
        Square square01 = new Square(2, "Red");
        Console.WriteLine(square01.GetColor());
        Console.WriteLine(square01.GetArea());
    }
}