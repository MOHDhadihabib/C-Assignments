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
    
    Console.Write("Enter Your Age:");
    int age =Convert.ToInt32(Console.ReadLine());
    
    if(age>= 18){
        Console.WriteLine(name + " You are eligibe for DrivingLIcense GO and Make");
    }
    else{
        Console.WriteLine(name +" You are not eligibe for DrivingLIcense");
    }
    
    
  }
}