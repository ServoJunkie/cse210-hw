public class Circle : Shape
{
    private double _radius;

    public Circle(double Radius, string Color) : base(Color)
    {
        _radius = Radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}