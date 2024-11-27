/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("Choose the input temperature unit:");
        Console.WriteLine("1. Celsius");
        Console.WriteLine("2. Fahrenheit");
        Console.WriteLine("3. Kelvin");
        Console.Write("Enter your choice (1, 2, or 3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the temperature value: ");
        double inputTemp = Convert.ToDouble(Console.ReadLine());
        double convertedTemp;

        switch (choice)
        {
            case 1:
                convertedTemp = (inputTemp * 9 / 5) + 32;
                Console.WriteLine($"{inputTemp}°C = {convertedTemp}°F");
                convertedTemp = inputTemp + 273.15;
                Console.WriteLine($"{inputTemp}°C = {convertedTemp}K");
                break;

            case 2:
                convertedTemp = (inputTemp - 32) * 5 / 9;
                Console.WriteLine($"{inputTemp}°F = {convertedTemp}°C");
                convertedTemp = (inputTemp - 32) * 5 / 9 + 273.15;
                Console.WriteLine($"{inputTemp}°F = {convertedTemp}K");
                break;

            case 3:
                convertedTemp = inputTemp - 273.15;
                Console.WriteLine($"{inputTemp}K = {convertedTemp}°C");
                convertedTemp = (inputTemp - 273.15) * 9 / 5 + 32;
                Console.WriteLine($"{inputTemp}K = {convertedTemp}°F");
                break;

            default:
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                break;
        
            
        }
    }
}
