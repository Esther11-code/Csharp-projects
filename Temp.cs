using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TemperatureConverter
{

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    public static void Main()
    {
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = FahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"{fahrenheit} F = {celsius} C");

        Console.Write("Enter the temperature in Celsius: ");
        celsius = Convert.ToDouble(Console.ReadLine());

        fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius} C = {fahrenheit} F");
    }
}
