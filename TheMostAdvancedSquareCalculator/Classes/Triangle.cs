using System.ComponentModel.DataAnnotations;
using TheMostAdvancedSquareCalculator.Exceptions;
using TheMostAdvancedSquareCalculator.Interfaces;

namespace TheMostAdvancedSquareCalculator.Classes;

public class Triangle : IGeometricShape
{
    /// <summary>
    /// Creates a new instance of the Triangle class.
    /// </summary>
    public Triangle(double sideA, double sideB, double sideC)
    {
        //check if sides are positive
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new SidesInvalidException();
        }
        
        // check if triangle is valid
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            throw new TriangleInvalidException();
        }
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    [Required] 
    private double SideA { get; }
    [Required] 
    private double SideB { get; }
    [Required] 
    private double SideC { get; }
    
    /// <summary>
    /// Calculates the area of the triangle
    /// </summary>
    /// <returns>Area of the triangle</returns>
    public double CalculateArea()
    {
        var halfPerimeter = GetHalfPerimeter();
        
        // Heron's formula
        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
    }
    
    public bool IsRightTriangle()
    {
        // Check if triangle is equilateral
        if (SideA + SideB - SideC == 0)
            return false;
        // Get the longest side
        var orderedSides = new[] {SideA, SideB, SideC}.OrderBy(x => x).ToArray();
        // Pythagorean theorem
        return orderedSides[0] * orderedSides[0] + orderedSides[1] * orderedSides[1] - orderedSides[2] * orderedSides[2] == 0;
    }
    
    private double GetHalfPerimeter()
    {
        return (SideA + SideB + SideC) / 2;
    }
}