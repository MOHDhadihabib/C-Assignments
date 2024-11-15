/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
   Console.Write("Enter any Number:");
   int num = Convert.ToInt32(Console.ReadLine());
   
   if(num > 0){
       Console.WriteLine("the number is Positive");
   }
   
   else if(num < 0){
       Console.WriteLine("the number is Negative");
   }

   else{
       Console.WriteLine("the number is zero ");
   }
  }
}