//Problem 6. Four-Digit Number

//    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//    Prints on the console the number in reversed order: dcba (in our example 1102).
//    Puts the last digit in the first position: dabc (in our example 1201).
//    Exchanges the second and the third digits: acbd (in our example 2101).

//    The number has always exactly 4 digits and cannot start with 0.

using System;

class fourDigitManipulation
{
    static void Main()
    {
        Console.Write("Please insert a four digit number: ");
        int number = int.Parse(Console.ReadLine());
        int min = 1000;
        int max = 9999;

        if (number <= min || number >= max)
        {
            Console.WriteLine("Wrong Number!");
        }
        else
        {
            int a = (number / 1000) % 10;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;

            int sum = a + b + c + d;

            Console.WriteLine("The sum of the digits is: " + sum);
            Console.WriteLine("Reverse order: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("First, Last reverse: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Second, Third reverse: {0}{1}{2}{3}", a, c, b, d);

        }
    }
}

