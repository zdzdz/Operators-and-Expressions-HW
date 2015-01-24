//Problem 5. Third Digit is 7?

//    Write an expression that checks for given integer if its third digit from right-to-left is 7.


using System;
using System.Numerics;

class checkThirdDigit
{
    static void Main()
    {
        Console.Write("Please insert a digit: ");
        BigInteger number = BigInteger.Parse(Console.ReadLine());

        bool result = (number / 100) % 10 == 7; 
        Console.WriteLine("The third digit of "+ number +" is 7 --> " + result);
    }
}

