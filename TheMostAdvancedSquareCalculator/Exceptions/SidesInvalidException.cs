namespace TheMostAdvancedSquareCalculator.Exceptions;

public class SidesInvalidException : Exception
{
    public SidesInvalidException() : base("Sides must be positive.")
    {
    }
}