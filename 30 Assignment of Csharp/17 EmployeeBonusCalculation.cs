/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter Your name:");
    string name = Console.ReadLine();
    
    Console.Write("How many Years You work in this compmany:");
    int Years =Convert.ToInt32(Console.ReadLine());
    
    if(Years>= 5){
        Console.WriteLine(name + " You have AWarded !0% Bonus");
    }
    else{
        Console.WriteLine(name +" You have AWarded 5% Bonus");
    }
    
    
  }
}