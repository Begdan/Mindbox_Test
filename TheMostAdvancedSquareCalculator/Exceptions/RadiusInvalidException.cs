namespace TheMostAdvancedSquareCalculator.Exceptions;

public class RadiusInvalidException : Exception
{
    public RadiusInvalidException() : base("Radius must be positive.")
    {
    }
}