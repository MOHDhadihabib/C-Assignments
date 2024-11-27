/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class HelloWorld {
    static void Main() {
        Console.WriteLine("Bill Calculator");

        Console.Write("Enter Units you consumed: ");
        int units = Convert.ToInt32(Console.ReadLine()); 

        double billAmount = 0;

        if (units <= 100)
        {
            billAmount = units * 5;
        }
        else if (units <= 300)
        {
            billAmount = 100 * 5 + (units - 100) * 7;
        }
        else
        {
            billAmount = 100 * 5 + 200 * 7 + (units - 300) * 10;
        }

        Console.WriteLine($"Total electricity bill: Rs. {billAmount}");
    }
}
