/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter Any Year:");  
    int year = Convert.ToInt32(Console.ReadLine());
    
if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))    
    
    {
        Console.WriteLine(year + " is a leap Year");
    }
    else
    {
        Console.WriteLine(year + " is not a leap Year");
    }
  }
}