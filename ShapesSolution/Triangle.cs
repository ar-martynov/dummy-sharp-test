namespace ShapesSolution;

public class Triangle : AbstractShape
{
    private readonly double[] _sides;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Triangle side value should be positive double");
        }

        _sides = new[] { a, b, c };
        {
            Array.Sort(_sides);
        }
    }

    public override double GetArea()
    {
        var a = _sides[0];
        var b = _sides[1];
        var c = _sides[2];

        var halfPerimeter = (a + b + c) / 2;

        return Math.Sqrt(
            halfPerimeter *
            (halfPerimeter - a) *
            (halfPerimeter - b) *
            (halfPerimeter - c)
        );
    }

    public bool IsCorrectShape()
    {
        var a = _sides[0];
        var b = _sides[1];
        var c = _sides[2];
        
        return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
    }
}