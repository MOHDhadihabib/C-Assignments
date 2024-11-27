/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0) {
            if (number % 2 == 0) {
                Console.WriteLine("The number is positive and even.");
            } else {
                Console.WriteLine("The number is positive and odd.");
            }
        } else if (number < 0) {
            if (number % 2 == 0) {
                Console.WriteLine("The number is negative and even.");
            } else {
                Console.WriteLine("The number is negative and odd.");
            }
        } else {
            Console.WriteLine("The number is zero, which is neither positive nor negative.");
        }  }
}