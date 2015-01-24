//Problem 7. Point in a Circle

//    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)

using System;

class checkCoordinates
{
    static void Main()
    {
        Console.Write("Insert the x coordinate: ");
        double xCoordinate = double.Parse(Console.ReadLine());
        Console.Write("Insert the y coordinate: ");
        double yCoordinate = double.Parse(Console.ReadLine());

        int radius = 2;
        bool check = Math.Pow(xCoordinate, 2) + Math.Pow(yCoordinate, 2) <= Math.Pow(radius, 2);

        Console.Write("Are the coordinates ({0}, {1}) inside circle K((0, 0), 2)? --> ", xCoordinate, yCoordinate);
        Console.WriteLine(check);
    }
}

