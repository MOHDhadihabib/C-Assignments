/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class HelloWorld 
{
    static int add(int a, int b) 
    {
        int c = a + b;
        return c;
    }
    
    static int sub(int a, int b) 
    {
        int c = a - b;
        return c;
    }
    
    static int mul(int a, int b) 
    {
        int c = a * b;
        return c;
    }
    
    static int div(int a, int b) 
    {
        int c = a / b;
        return c;
    }
    
    static int square(int a) 
    {
        int c = a * a;
        return c;
    }
    
    static int cube(int a) 
    {
        int c = a * a * a;
        return c;
    }
    
    static double average(int a, int b) 
    {
        double c = (a + b) / 2.0;
        return c;
    }

    static void Main() 
    {
        Console.Write("Enter first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        int sum = add(firstNumber, secondNumber);
        Console.WriteLine(sum);

        int difference = sub(firstNumber, secondNumber);
        Console.WriteLine(difference);

        int product = mul(firstNumber, secondNumber);
        Console.WriteLine(product);

        int quotient = div(firstNumber, secondNumber);
        Console.WriteLine(quotient);

        int sq = square(firstNumber);
        Console.WriteLine(sq);

        int cb = cube(firstNumber);
        Console.WriteLine(cb);

        double avg = average(firstNumber, secondNumber);
        Console.WriteLine(avg);
    }
}