public class Rectangle : Shape
{
    private double _height;
    private double _length;

    public Rectangle(string color, double height, double length) : base(color)
    {
        _height = height;
        _length = length;
    }

    public override double GetArea()
    {
        double area = _height * _length;

        return area;
    }
}