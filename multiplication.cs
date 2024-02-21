using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ass
    {
        static void Main()
        {

            /*
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int cube = i * i * i;
                Console.WriteLine("Cube of {0}: {1}", i, cube);
            }


            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication Table for {0}:", number);
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine("{0} x {1} = {2}", number, i, result);
            }
            */


            /*
            Console.Write("Enter the number for the multiplication table: ");
            int max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication Table from 1 to {0}:", max);

            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine("\nMultiplication table for {0}:", i);
                for (int r = 1; r <= 10; r++)
                {
                    int result = i * r;
                    Console.WriteLine("{0} x {1} = {2}", i, r, result);
                }
            }

            */




                Console.Write("Enter an integer (n): ");

                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    if (n > 0)
                    {
                        int sum = 0;
                        Console.Write($"The first {n} odd natural numbers are: ");
                        for (int i = 1; i <= n * 2; i += 2)
                        {
                            Console.Write($"{i} ");
                            sum += i;
                        }

                        Console.WriteLine($"\nThe sum of the first {n} odd natural numbers is: {sum}");
                    }
                    
                }
               


                        
                        Console.Write("Enter the number of rows for the right-angled triangle: ");

                        if (int.TryParse(Console.ReadLine(), out int numRows))
                        {
                            if (numRows > 0)
                            {
                                Console.WriteLine("Right-Angled Triangle:");

                                for (int i = 1; i <= numRows; i++)
                                {
                                    for (int j = 1; j <= i; j++)
                                    {
                                        Console.Write("* ");
                                    }

                                    Console.WriteLine();
                                }
                            }
              
                        }




                         int user;
                        Console.Write("\n\n");
                        Console.WriteLine("Input the number of rows: ");
                        Console.WriteLine("\n\n");
                        user = Convert.ToInt32(Console.ReadLine());
                        for(int i = 1; i <= user; i++) 
                        {
                            for(int j = 0; j < i; j++)
                            {
                                Console.WriteLine(" " + i);
                            }
                            Console.WriteLine("\n");
                        }
          




        }    
    }   
}


