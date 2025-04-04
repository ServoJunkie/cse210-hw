using System;

class Program
{
    static void Main(string[] args)
    {
        Square square01 = new Square(2, "Red");
        Console.WriteLine(square01.GetColor());
        Console.WriteLine(square01.GetArea());

        Rectangle rectangle02 = new Rectangle(2, 4, "Blue");
        Console.WriteLine(rectangle02.GetColor());
        Console.WriteLine(rectangle02.GetArea());

        Circle circle03 = new Circle(2, "Green");
        Console.WriteLine(circle03.GetArea());
        Console.WriteLine(circle03.GetColor());
    }
}