/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
        Console.Write("Enter your First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int add = num1 + num2;
        int sub = num1 - num2;
        int mul = num1 * num2;
        int div = num1 / num2;

        Console.WriteLine("Your Addition Answer is: " + add);
        Console.WriteLine("Your Subtraction Answer is: " + sub);
        Console.WriteLine("Your Multiplication Answer is: " + mul);
        Console.WriteLine("Your Division Answer is: " + div);

  }
}