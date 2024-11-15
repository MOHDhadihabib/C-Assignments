/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter Any Number");
    double Number = Convert.ToDouble(Console.ReadLine());
    if((Number % 5 == 0)&&(Number % 11 ==0)){
        Console.WriteLine("The Number is DIvisible by 5 and 11 ");
    }
    else if(Number % 5 == 0){
        Console.WriteLine("The Number is DIvisible by 5 and not DIvisible by 11 ");
    }
    
    else if(Number % 11 == 0){
        Console.WriteLine("The Number is DIvisible by 11 and not DIvisible by 5");
        
    }
    else{
        Console.WriteLine("The Number is not DIvisible by 5 and 11");
    }
    
    
        
    }
  }
