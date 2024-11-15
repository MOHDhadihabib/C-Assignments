/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter First Number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter Second Number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter Third Number");
    int num3 = Convert.ToInt32(Console.ReadLine());
    
    if(num1>num2){
        if(num1>num3){
            Console.WriteLine("The largest Number is " + num1);
        }
        else
        {Console.WriteLine("The largest Number is " + num3);}
    }
    else{
         if(num2>num3){
            Console.WriteLine("The largest Number is " + num2);
        }
        else
        {Console.WriteLine("The largest Number is " + num3);}
    }
  }
}