/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter the traffic light color (Red, Yellow, Green):");
        string color = Console.ReadLine();
        color = color.ToLower();

        switch (color)
        {
            case "red":
                Console.WriteLine("Stop, the light is Red.");
                break;

            case "yellow":
                Console.WriteLine("Caution, the light is Yellow.");
                break;

            case "green":
                Console.WriteLine("Go, the light is Green.");
                break;

            default:
                Console.WriteLine("Invalid color. Please enter Red, Yellow, or Green.");
                break;
        }
  }
}