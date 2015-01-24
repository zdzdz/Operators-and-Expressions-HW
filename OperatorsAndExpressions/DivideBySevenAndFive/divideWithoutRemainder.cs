//Problem 3. Divide by 7 and 5

//    Write a Boolean expression that checks for given integer if it can be divided
//    (without remainder) by 7 and 5 at the same time.


using System;

class divideWithoutRemainder
{
    static void Main()
    {
        Console.Write("Please insert a number: ");
        int number = int.Parse(Console.ReadLine());

        bool result = number % 7 == 0 && number % 5 == 0 && number / 7 != 0 && number / 5 != 0;

        Console.WriteLine("Can this number be divided by 7 and 5 without remainder? --> {0}", result);
    }
}

