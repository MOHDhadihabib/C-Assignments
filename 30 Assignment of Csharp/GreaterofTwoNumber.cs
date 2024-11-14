/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      Console.Write("Enter First Number:");
      int num1 = Convert.ToInt32(Console.ReadLine());
      
      Console.Write("Enter Second Number:");
      int num2 = Convert.ToInt32(Console.ReadLine());
      
      if(num1>num2){
          Console.WriteLine(num1 + " is greater than " + num2);
      }
      
      else if(num1<num2){
          Console.WriteLine(num2 + " is greater than " + num1);
      }
      
      else{
          Console.WriteLine("Both are Equal");
      }

  }
}