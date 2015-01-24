//Problem 12. Extract Bit from Integer

//    Write an expression that extracts from given integer n the value of given bit at index p.


using System;

class extractBit
{
    static void Main()
    {
        Console.Write("Please insert a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please insert a position for the bit: ");
        int position = int.Parse(Console.ReadLine());
        number = (number >> position) & 1;

        Console.WriteLine("The value of bit #" + position + " is: " + number);
    }
}

