using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class conditionals
    {
        static void Main(string[] args)
        {
            if (3 < 10)
            {
                Console.WriteLine("This is true");
            }

            int firstValue = 30;
            int secondValue = 25;
            if (firstValue == secondValue)
            {
                Console.WriteLine("The first value is equal to the second value");
            }
            else if (firstValue < secondValue) 
            {
                Console.WriteLine("The first value is less than second value");
            }
            else 
            {
                Console.WriteLine("The second value is greater than the first value");
            }

            // Ternary Operators or the short if-else statements 
            int counting = 40;
            string newResult = (counting < 25) ? "Incorrect option" : "Correct option";
            Console.WriteLine(newResult);

            // Switch - case statements
            int month = 7;
            switch (month) 
            {
                case 1:
                    Console.WriteLine("First Month");
                    break;
                case 2:
                    Console.WriteLine("Second Month");
                    break;
                case 3:
                    Console.WriteLine("Third Month");
                    break;
                case 4:
                    Console.WriteLine("Fourth Month");
                    break;
                case 5:
                    Console.WriteLine("Fifth Month");
                    break;
                default:
                    Console.WriteLine("Damn it's another month");
                    break;
            }

            int score = int.Parse(Console.ReadLine());

            switch (score / 100)
            {
                
                case 1:
                    Console.WriteLine("Your grade is A");
                    break;
                case 2:
                    Console.WriteLine("Your grade is B");
                    break;
                case 3:
                    Console.WriteLine("Your grade is C");
                    break;
                case 4:
                    Console.WriteLine("Your grade is D");
                    break;
                default:
                    Console.WriteLine("Your grade is F");
                    break;
            }

            Console.WriteLine("Enter a number to check grade");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num > 100) 
            {
                Console.WriteLine("Wrong number");
            }
            else if (num >= 0 && num < 50)
            {
                Console.WriteLine("Failure!!");
            }
            else if (num >= 50 && num < 60)
            {
                Console.WriteLine("D Grade");
            }
            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (num >= 90 && num <= 100)
            {
                Console.WriteLine("A+ Grade");
            }

            switch (num)
            {
                case int n when (n < 0 || n > 100):
                    Console.WriteLine("Wrong number");
                    break;
                case int n when (n < 50):
                    Console.WriteLine("Failure!!");
                    break;
                case int n when (n < 60):
                    Console.WriteLine("D Grade");
                    break;
                case int n when (n < 70):
                    Console.WriteLine("C Grade");
                    break;
                case int n when (n < 80):
                    Console.WriteLine("B Grade");
                    break;
                case int n when (n < 90):
                    Console.WriteLine("A Grade");
                    break;
                case int n when (n <= 100):
                    Console.WriteLine("A+ Grade");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }
    }
}
