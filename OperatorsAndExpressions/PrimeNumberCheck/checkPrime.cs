//Problem 8. Prime Number Check

//    Write an expression that checks if given positive integer number n (n <= 100) is prime 
//    (i.e. it is divisible without remainder only to itself and 1).
//    Note: You should check if the number is positive.


using System;

class checkPrime
{
    static void Main()
    {
        Console.Write("Insert a positive digit: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }
        }
        
        if (number <= 1)
        {
            Console.WriteLine("Is your number prime? --> " + !isPrime);
        }
        else
        {
            Console.WriteLine("Is your number prime? --> " + isPrime);
        }

    }
}

