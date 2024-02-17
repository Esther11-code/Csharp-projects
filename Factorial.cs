using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static int Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        int result = Factorial(input);
        Console.WriteLine("The factorial of " + input + " is " + result);
    }
}
