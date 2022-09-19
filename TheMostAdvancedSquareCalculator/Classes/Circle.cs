using System.ComponentModel.DataAnnotations;
using TheMostAdvancedSquareCalculator.Exceptions;
using TheMostAdvancedSquareCalculator.Interfaces;

namespace TheMostAdvancedSquareCalculator.Classes;

public class Circle : IGeometricShape
{
    /// <summary>
    /// Creates a new instance of the Circle class.
    /// </summary>
    public Circle(double radius)
    {
        //check if radius is positive
        if (radius <= 0)
        {
            throw new RadiusInvalidException();
        }
        
        Radius = radius;
    }

    [Required] 
    private double Radius { get; }

    /// <summary>
    /// Calculates the area of the circle
    /// </summary>
    /// <returns>Area of the circle</returns>
    public double CalculateArea()
    {
        return MathF.PI * (Radius * Radius);
    }
}