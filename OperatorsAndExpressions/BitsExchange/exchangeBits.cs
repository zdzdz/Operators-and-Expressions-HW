﻿//Problem 15.* Bits Exchange

﻿//  Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of 
//  given 32-bit unsigned integer.

using System;
class exchangeBits
{
    static void Main()
    {
        int lowIndex = 3;
        int highIndex = 24;
        int increment = 2;
        Console.Write("Please insert a number: ");
        uint number = UInt32.Parse(Console.ReadLine());
        //My idea is to convert the number to binary stored in a string and
        //switch parts of it to get the new one and then convert it back to decimal.
        string bitRepresentation = Convert.ToString(number, 2);
        string lowBlock = "";
        string highBlock = "";
        string exchangedBitNumber = "";
        if (bitRepresentation.Length < 27)
        {
            bitRepresentation = bitRepresentation.PadLeft(27, '0');
        }
        for (int i = lowIndex + increment; i >= lowIndex; i--)
        {
            lowBlock += Convert.ToString(bitRepresentation[bitRepresentation.Length - 1 - i]);
        }
        for (int j = highIndex + increment; j >= highIndex; j--)
        {
            highBlock += Convert.ToString(bitRepresentation[bitRepresentation.Length - 1 - j]);
        }
        for (int k = 0; k < bitRepresentation.Length - 1 - highIndex - increment; k++)
        {
            exchangedBitNumber += Convert.ToString(bitRepresentation[k]);
        }
        exchangedBitNumber += lowBlock;
        for (int l = bitRepresentation.Length - highIndex; l < bitRepresentation.Length - 1 - lowIndex - increment; l++)
        {
            exchangedBitNumber += Convert.ToString(bitRepresentation[l]);
        }
        exchangedBitNumber += highBlock;
        for (int m = bitRepresentation.Length - lowIndex; m < bitRepresentation.Length; m++)
        {
            exchangedBitNumber += Convert.ToString(bitRepresentation[m]);
        }
        Console.WriteLine("The new number is: " + Convert.ToUInt32(exchangedBitNumber, 2));
    }
}
