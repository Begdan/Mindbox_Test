using TheMostAdvancedSquareCalculator.Interfaces;

namespace TheMostAdvancedSquareCalculator;

public class AreaCalculator
{
    /// <summary>
    /// Calculates the area of a geometric shape.
    /// </summary>
    /// <param name="shape">Geometric shape</param>
    /// <returns>Area of a shape</returns>
    public double CalculateArea(IGeometricShape shape)
    { 
        return shape.CalculateArea();
    }
}