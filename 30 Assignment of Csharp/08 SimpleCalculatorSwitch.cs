using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter First Number:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    
    
    Console.Write("Enter Your operator:");
    string operation = Console.ReadLine();
    
    Console.Write("Enter Second Number:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    
    switch(operation){
        case "+":
        Console.WriteLine("Your Answer is " + num1 + " + " + num2 + " = " + (num1 + num2));
        break;
        
        case "-":
        Console.WriteLine("Your Answer is " + num1 + " - " + num2 + " = " + (num1 - num2));
        break;
        
        case "*":
        Console.WriteLine("Your Answer is " + num1 + " * " + num2 + " = " + (num1 * num2));
        break;
        
        case "/":
        Console.WriteLine("Your Answer is " + num1 + " / " + num2 + " = " + (num1 / num2));
        break;
        
        default:
        Console.WriteLine("invalid operator");
        break;
    }
  }
}
