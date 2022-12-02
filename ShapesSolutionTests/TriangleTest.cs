namespace ShapesSolutionTests;

[TestFixture]
public class TriangleTest
{
    [Test]
    public void AreArgumentsZero()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, 2, 3));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 0, 3));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 0));
    }

    [Test]
    public void AreArgumentsLessThanZero()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-1, 2, 3));
        Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 3));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, -1));
    }

    [Test]
    public void IsAreaCalculationCorrect()
    {
        IShape shape = new Triangle(3, 4, 5);
        Assert.AreEqual(6, shape.GetArea(), 1E-6, "Area is incorrect!");
    }

    [Test]
    public void IsTriangleRight()
    {
        var triangle = new Triangle(12, 16, 20);
        Assert.IsTrue(triangle.IsCorrectShape());
    }

    [Test]
    public void IsTriangleNotRight()
    {
        var triangle = new Triangle(1, 2, 3);
        Assert.IsTrue(triangle.IsCorrectShape());
    }
}