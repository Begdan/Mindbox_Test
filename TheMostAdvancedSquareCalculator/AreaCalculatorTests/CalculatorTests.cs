using NUnit.Framework;
using TheMostAdvancedSquareCalculator;
using TheMostAdvancedSquareCalculator.Classes;

namespace AreaCalculatorTests;

public class CalculatorTests
{
    [Test]
    public void ValidCircleArea()
    {
        var calculator = new AreaCalculator();
        var circle = new Circle(5);
        var area = calculator.CalculateArea(circle);
        Assert.AreEqual(78.5398, area, 0.0001);
    }
    
    [Test]
    public void ValidTriangleArea()
    {
        var calculator = new AreaCalculator();
        var triangle = new Triangle(5, 10, 11);
        var area = calculator.CalculateArea(triangle);
        Assert.AreEqual(25, area, 0.1);
    }
}