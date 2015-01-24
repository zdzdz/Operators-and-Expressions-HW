//Problem 1. Odd or Even Integers

//    Write an expression that checks if given integer is odd or even.


using System;

class isintOdd
{
    static void Main()
    {
        Console.Write("Insert an integer: ");
        int number = int.Parse(Console.ReadLine());

        bool isOdd = (number % 2) != 0;
       
        Console.WriteLine("Is that integer odd? --> " + isOdd);
    }
}
