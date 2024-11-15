/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter Any number");
    int number = Convert.ToInt32(Console.ReadLine());
    
    switch(number % 2 == 0){
        case true:
        Console.WriteLine("The Number is Even");
        break;
        default:
        Console.WriteLine("The Number is Odd");
        break;
    }
  }
}
