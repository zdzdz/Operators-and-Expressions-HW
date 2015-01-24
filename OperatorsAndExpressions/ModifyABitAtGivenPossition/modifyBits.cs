//Problem 14. Modify a Bit at Given Position

//    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//    Write a sequence of operators (a few lines of C# code) that modifies n 
//    to hold the value v at the position p from the binary representation of n 
//    while preserving all other bits in n.


using System;

class modifyBits
{
    static void Main()
    {
        Console.Write("Please insert a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please insert a position for the bit: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Please insert a new bit value: ");
        int bitValue = int.Parse(Console.ReadLine());

        int change;
        if (bitValue == 0)
        {
            change = ~(1 << position);
            Console.WriteLine(number & change);
        }
        else
        {
            change = 1 << position;
            Console.WriteLine(number | change);
        }
    }
}

