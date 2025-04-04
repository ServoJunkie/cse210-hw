public class Square : Shape
{
    private double _side;

    public Square(double Side, string Color) : base(Color)
    {
        _side = Side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}