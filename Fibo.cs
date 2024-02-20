using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms for the Fibonacci sequence: ");

        // Validate user input for a positive integer
        if (int.TryParse(Console.ReadLine(), out int numberOfTerms) && numberOfTerms > 0)
        {
            List<int> fibonacciSequence = GenerateFibonacciSequence(numberOfTerms);

            Console.WriteLine($"Fibonacci sequence up to {numberOfTerms} terms:");
            foreach (int number in fibonacciSequence)
            {
                Console.Write($"{number} ");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    static List<int> GenerateFibonacciSequence(int numberOfTerms)
    {
        List<int> fibonacciSequence = new List<int>();

        if (numberOfTerms >= 1)
        {
            fibonacciSequence.Add(0);
        }
        if (numberOfTerms >= 2)
        {
            fibonacciSequence.Add(1);
        }

        for (int i = 2; i < numberOfTerms; i++)
        {
            int nextNumber = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            fibonacciSequence.Add(nextNumber);
        }

        return fibonacciSequence;
    }
}
