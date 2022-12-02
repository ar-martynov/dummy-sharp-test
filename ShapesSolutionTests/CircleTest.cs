namespace ShapesSolutionTests;

[TestFixture]
public class CircleTest
{
    [Test]
    public void IsRadiusZero()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0.0));
    }

    [Test]
    public void IsRadiusLessThanZero()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1.0));
    }

    [Test]
    public void IsAreaCalculationCorrect()
    {
        IShape shape = new Circle(14);

        Assert.AreEqual(615.7521601035994, shape.GetArea(), 1E-6, "Area is incorrect!");
    }
}