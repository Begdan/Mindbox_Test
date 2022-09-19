using System;
using NUnit.Framework;
using TheMostAdvancedSquareCalculator.Classes;
using TheMostAdvancedSquareCalculator.Exceptions;

namespace AreaCalculatorTests;

public class CircleTests
{
    [Test]
    public void InvalidRadiusTest()
    {
        Assert.Throws<RadiusInvalidException>(() =>
        {
            var circle = new Circle(-1);
        });
    }
    
    [Test]
    public void ValidRadiusTest()
    {
        var circle = new Circle(1);
        Assert.AreEqual(MathF.PI, circle.CalculateArea());
    }
}