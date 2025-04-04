public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double Length, double Width, string Color) : base(Color)
    {
        _length = Length;
        _width = Width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}