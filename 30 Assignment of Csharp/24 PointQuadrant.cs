/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
Console.Write("Enter the x-coordinate: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the y-coordinate: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine("The point is at the origin.");
        }
        else if (x == 0)
        {
            Console.WriteLine("The point lies on the Y-axis.");
        }
        else if (y == 0)
        {
            Console.WriteLine("The point lies on the X-axis.");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("The point lies in the First Quadrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point lies in the Second Quadrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point lies in the Third Quadrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The point lies in the Fourth Quadrant.");
        }
      
  }
}