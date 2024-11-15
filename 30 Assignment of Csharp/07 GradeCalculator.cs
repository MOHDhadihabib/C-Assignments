/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter Your Name");
    string Name = Console.ReadLine();
    
    int math, sci, urdu, isl, sst, sindhi, obtainedMarks, Percantage;
    
    Console.Write("Enter your Maths marks");
    math = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter your Science marks");
    sci = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter your Urdu marks");
    urdu = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter your Islamiat marks");
    isl = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter your Social studies marks");
    sst = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter your Sindhi marks");
    sindhi = Convert.ToInt32(Console.ReadLine());
    
    obtainedMarks = math + sci + urdu + isl + sst + sindhi;
    Console.WriteLine("Your obtainedMarks is " + obtainedMarks);
    
    Percantage = (obtainedMarks * 100) / 600;
    Console.WriteLine("Your Percantage is " + Percantage);
    
    if (Percantage >= 80 && Percantage <= 100) {
        Console.WriteLine(Name + " Your Grade is A1");
    }
    else if (Percantage >= 70 && Percantage <= 79) {
        Console.WriteLine(Name + " Your Grade is A");
    }
    else if (Percantage >= 60 && Percantage <= 69) {
        Console.WriteLine(Name + " Your Grade is B");
    }
    else if (Percantage >= 50 && Percantage <= 59) {
        Console.WriteLine(Name + " Your Grade is C");
    }
    else if (Percantage >= 40 && Percantage <= 49) {
        Console.WriteLine(Name + " Your Grade is D");
    }
    else {
        Console.WriteLine("Sorry " + Name + " You are fail");
    }
  }
}