//Problem 9. Trapezoids

//    Write an expression that calculates trapezoid's area by given sides a and b and height h.


using System;

class trapezoidArea
{
    static void Main()
    {
        Console.Write("Insert trapezoid's side a: ");
        double aSide = double.Parse(Console.ReadLine());
        Console.Write("Insert trapezoid's side b: ");
        double bSide = double.Parse(Console.ReadLine());
        Console.Write("Insert trapezoid's height: ");
        double height = double.Parse(Console.ReadLine());

        double area = ((aSide + bSide) / 2) * height;

        Console.WriteLine("Trapezoid's area is " + area);
    }
}

