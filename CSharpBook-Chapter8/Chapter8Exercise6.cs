using System;

class Exercise6
{
    public static double FahrenheitToCelsius(double degrees)
    {
        double celsius = (degrees - 32) * 5 / 9;
        return celsius;
    }
}