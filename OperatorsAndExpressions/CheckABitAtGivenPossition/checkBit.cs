//Problem 13. Check a Bit at Given Position

//    Write a Boolean expression that returns if the bit at position p 
//    (counting from 0, starting from the right) in given integer number n, has value of 1.


using System;

class checkBit
{
    static void Main()
    {
        Console.Write("Please insert a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please insert a position for the bit: ");
        int position = int.Parse(Console.ReadLine());
        number = (number >> position) & 1;

        bool check = number == 1;

        Console.WriteLine("Is the value of bit #" + position + " , 1? --> " + check);

    }
}

