using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();
        
        Square square01 = new Square(2, "Red");
        Console.WriteLine(square01.GetColor());
        Console.WriteLine(square01.GetArea());
        _shapes.Add(square01);

        Rectangle rectangle02 = new Rectangle(2, 4, "Blue");
        Console.WriteLine(rectangle02.GetColor());
        Console.WriteLine(rectangle02.GetArea());
        _shapes.Add(rectangle02);

        Circle circle03 = new Circle(2, "Green");
        Console.WriteLine(circle03.GetColor());
        Console.WriteLine(circle03.GetArea());
        _shapes.Add(circle03);

        foreach (Shape currentShape in _shapes)
        {
            Console.WriteLine(currentShape.GetColor());
            Console.WriteLine(currentShape.GetArea());
        }
    }
}