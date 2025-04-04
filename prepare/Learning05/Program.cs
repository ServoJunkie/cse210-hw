using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();
        
        Square square01 = new Square(3, "Red");
        _shapes.Add(square01);

        Rectangle rectangle02 = new Rectangle(4, 5, "Blue");
        _shapes.Add(rectangle02);

        Circle circle03 = new Circle(6, "Green");
        _shapes.Add(circle03);

        foreach (Shape currentShape in _shapes)
        {
            string Color = currentShape.GetColor();
            double Area = currentShape.GetArea();

            Console.WriteLine($"The {Color} shape has an area of {Area}.");
        }
    }
}