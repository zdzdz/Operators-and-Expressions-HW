//Problem 4. Rectangles

//    Write an expression that calculates rectangle’s perimeter and area by given width and height.


using System;

class calcAreaAndPerimeter
{
    static void Main()
    {
        Console.Write("Insert rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Insert rectangle's height: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Rectangle's perimeter is {0}", (height + width) * 2);
        Console.WriteLine("Rectangle's area is {0}", height * width);

    }
}

