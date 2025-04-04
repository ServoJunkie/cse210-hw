public class Shape
{
    private string _color;

    public Shape(string Color)
    {
        SetColor(Color);
    }
    
    public void SetColor(string Color)
    {
        _color = Color;
    }

    public string GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return -1;
    }
}