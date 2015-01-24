//Problem 10. Point Inside a Circle & Outside of a Rectangle

//    Write an expression that checks for given point (x, y) if it is within 
//    the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).


using System;

class checkCoordinates
{
    static void Main()
    {
        Console.Write("Insert the x coordinate: ");
        double xCoordinate = double.Parse(Console.ReadLine());
        Console.Write("Insert the y coordinate: ");
        double yCoordinate = double.Parse(Console.ReadLine());

        double radius = 1.5;
        bool checkCircle = Math.Pow(xCoordinate - 1, 2) + Math.Pow(yCoordinate - 1, 2) <= Math.Pow(radius, 2);

        bool checkRectangle = !(-1 <= xCoordinate && xCoordinate <= 5 && -1 <= yCoordinate && yCoordinate <= 1);

        Console.WriteLine("Are the coordinates inside the circle and outside the rectangle? --> " + (checkCircle && checkRectangle));


    }
}

