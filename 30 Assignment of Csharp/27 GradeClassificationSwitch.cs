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
        Console.Write("Enter the numerical score (0-100): ");
        int score = Convert.ToInt32(Console.ReadLine());
        char grade;

        if (score >= 0 && score <= 100)
        {
            
            switch (score / 10)
            {
                case 10:
                case 9:
                    grade = 'A';
                    break;
                case 8:
                    grade = 'B';
                    break;
                case 7:
                    grade = 'C';
                    break;
                case 6:
                    grade = 'D';
                    break;
                default:
                    grade = 'F';
                    break;
            }

            Console.WriteLine($"The letter grade is: {grade}");
        }
        else
        {
            Console.WriteLine("Invalid score! Please enter a score between 0 and 100.");
        }
    }
}
