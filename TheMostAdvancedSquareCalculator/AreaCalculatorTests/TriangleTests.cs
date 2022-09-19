using NUnit.Framework;
using TheMostAdvancedSquareCalculator.Classes;
using TheMostAdvancedSquareCalculator.Exceptions;

namespace AreaCalculatorTests;

public class TriangleTests
{
    [Test]
    public void InvalidTriangleSidesTest()
    {
        Assert.Throws<TriangleInvalidException>(() =>
        {
            var triangle = new Triangle(5, 3, 9);
        });
    }
    
    [Test]
    public void InvalidEquilateralTriangleSidesTest()
    {
        var triangle = new Triangle(5, 5, 5);

        Assert.AreEqual(false, triangle.IsRightTriangle());
    }
    
    [Test]
    public void InvalidNegativeSideTest()
    {
        Assert.Throws<SidesInvalidException>(() =>
        {
            var triangle = new Triangle(5, 5, -5);
        });
    }
    
    [Test]
    public void ValidTriangleAreaTest()
    {
        var triangle = new Triangle(5, 3, 4);

        Assert.AreEqual(6, triangle.CalculateArea());
    }
    
    [Test]
    public void ValidEquilateralTriangleAreaTest()
    {
        var triangle = new Triangle(5, 5, 5);

        Assert.AreEqual(10.825317547305483, triangle.CalculateArea());
    }

    [Test]
    public void ValidRightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);

        Assert.AreEqual(true, triangle.IsRightTriangle());
    }
}