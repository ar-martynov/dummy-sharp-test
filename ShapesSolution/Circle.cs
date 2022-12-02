namespace ShapesSolution;

public class Circle : AbstractShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius should be positive double");
        }
        
        _radius = radius;
    }

    public override double GetArea()
    {
       return Math.PI * Math.Pow(_radius, 2);
    }
}