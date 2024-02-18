using System;
namespace consoleApp
{
	public class Areacalculator
	{
		public Areacalculator()
		{
            
            static void Main(string[] args)
            {
                Console.WriteLine("Choose a shape:");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Triangle");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CalculateRectangleArea();
                        break;
                    case 2:
                        CalculateSquareArea();
                        break;
                    case 3:
                        CalculateTriangleArea();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

            static void CalculateRectangleArea()
            {
                double length, width, area;

                Console.WriteLine("Enter the length of the rectangle:");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the width of the rectangle:");
                width = Convert.ToDouble(Console.ReadLine());

                area = length * width;

                Console.WriteLine("The area of the rectangle is: " + area);
            }

            static void CalculateSquareArea()
            {
                double side, area;

                Console.WriteLine("Enter the side length of the square:");
                side = Convert.ToDouble(Console.ReadLine());

                area = side * side;

                Console.WriteLine("The area of the square is: " + area);
            }

            static void CalculateTriangleArea()
            {
                double baseLength, height, area;

                Console.WriteLine("Enter the base length of the triangle:");
                baseLength = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the height of the triangle:");
                height = Convert.ToDouble(Console.ReadLine());

                area = 0.5 * baseLength * height;

                Console.WriteLine("The area of the triangle is: " + area);
            }
        }
    }
	
}

