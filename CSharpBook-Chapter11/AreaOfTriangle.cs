using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Write a program which calculates the area of a triangle with the following given:
-     three sides;
-     side and the altitude to it;
-     two sides and the angle between them in degrees. */
class AreaOfTriangle
{
    public static void Main()
    {
        
        Console.WriteLine(@"Which method do you want to use, so you can calculate the triangle's area?
        three sides - 0;
        side and the altitude to it - 1;
        two sides and the angle between them in degrees - 2");
        int option = int.Parse(Console.ReadLine());
        double side, sideA, sideB, sideC, altitude;
        int angle;
        switch (option)
        {
            case 0:
                {
                    Console.Write("Insert the 3 sides: ");
                    sideA = double.Parse(Console.ReadLine());
                    sideB = double.Parse(Console.ReadLine());
                    sideC = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the triangle: {0,2:F}", TriangleArea(sideA, sideB, sideC));
                    break;
                }
            case 1:
                {
                    Console.Write("Insert a side: ");
                    side = double.Parse(Console.ReadLine());
                    Console.Write("Insert an altitude: ");
                    altitude = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the triangle: {0,2:F}", TriangleArea(side, altitude));
                    break;
                }
            case 2:
                {
                    Console.Write("Insert 2 sides: ");
                    sideA = double.Parse(Console.ReadLine());
                    sideB = double.Parse(Console.ReadLine());
                    Console.Write("Insert an angle: ");
                    angle = int.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the triangle: {0,2:F}", TriangleArea(sideA, sideB, angle));
                    break;
                }
            default: break;
        }
    }
    public static double TriangleArea(double sideA, double sideB, double sideC)
    {
        double semiPerimeter = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        return area;
    }
    public static double TriangleArea( double side, double altitude)
    {
        double area = side * altitude / 2;
        return area;
    }
    public static double TriangleArea(double sideA, double sideB, int angle)
    {
        double area = (sideA * sideB * Math.Sin((double)angle)) / 2;
        return area;
    }
}