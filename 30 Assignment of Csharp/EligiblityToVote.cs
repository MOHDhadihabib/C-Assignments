/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      Console.Write("Enter Your Name:");
      String Name = Console.ReadLine();
      
      Console.Write("Enter Your age:");
      int age = Convert.ToInt32(Console.ReadLine());
      
      if(age>= 18){
          Console.WriteLine(Name  + " You are eligible to vote Go and Vote");
      }
      
      else{
          Console.WriteLine(Name  + " Sorry you are not eligible to Vote");
      }
  }
}