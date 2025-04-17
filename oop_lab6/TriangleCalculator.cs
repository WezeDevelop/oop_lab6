using System;

public static class TriangleCalculator
{
    public static (double angleA, double angleB) CalculateAngles(double legA, double legB)
    {
        if (legA <= 0 || legB <= 0)
            throw new ArgumentException("Довжини катетів повинні бути більше нуля");

        double hypotenuse = Math.Sqrt(legA * legA + legB * legB);
        double angleA = Math.Atan(legA / legB) * (180 / Math.PI);
        double angleB = 90 - angleA;

        return (angleA, angleB);
    }
}