﻿//Problem 2. Gravitation on the Moon

//    The gravitational field of the Moon is approximately 17% of that on the Earth.
//    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.


using System;

class calculateWeightOnTheMoon
{
    static void Main()
    {
        Console.Write("Insert your weight: ");

        double weightOnEarth = double.Parse(Console.ReadLine());

        double weightOnMoon = (weightOnEarth * 17) / 100;

        Console.WriteLine("yor weight on the Moon is: " + weightOnMoon);





    }
}

