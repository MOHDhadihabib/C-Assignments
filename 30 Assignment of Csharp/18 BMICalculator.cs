/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
     Console.Write("Enter your weight in kilograms: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height in meters: ");
        double height = Convert.ToDouble(Console.ReadLine());
        
        double bmi = weight / (height * height);
        
         if (bmi < 18.5)
            Console.WriteLine("Underweight");
        else if (bmi >= 18.5 && bmi < 24.9)
            Console.WriteLine("Normal weight");
        else if (bmi >= 25 && bmi < 29.9)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");
  }
}