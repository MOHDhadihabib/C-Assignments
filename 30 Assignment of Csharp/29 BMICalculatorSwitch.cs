/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter your weight in kilograms:");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your height in meters:");
        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height);
        Console.WriteLine("Your BMI is: " + bmi);

        int bmiCategory;

        if (bmi < 18.5)
        {
            bmiCategory = 1;
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            bmiCategory = 2;
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            bmiCategory = 3;
        }
        else
        {
            bmiCategory = 4;
        }

        switch (bmiCategory)
        {
            case 1:
                Console.WriteLine("You are Underweight. It's important to eat a balanced diet.");
                break;
            case 2:
                Console.WriteLine("You have a Normal weight. Keep up the healthy lifestyle!");
                break;
            case 3:
                Console.WriteLine("You are Overweight. Consider a healthier diet and more physical activity.");
                break;
            case 4:
                Console.WriteLine("You are Obese. It's highly recommended to consult a healthcare provider.");
                break;
            default:
                Console.WriteLine("Invalid BMI category.");
                break;
        }
  }
}