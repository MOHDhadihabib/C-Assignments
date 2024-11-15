using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter any Number from 1 to 7 ");
    string Number = Console.ReadLine();
    
    switch(Number){
        case "1":
        case "One":
        Console.WriteLine("Monday");
        break;
                
        case "2":
        case "Two":
        Console.WriteLine("Tuesday");
        break;
        
        case "3":
        case "Three":
        Console.WriteLine("Wednesday");
        break;
        
        case "4":
        case "Four":
        Console.WriteLine("Thursday");
        break;
        
        case "5":
        case "Five":
        Console.WriteLine("Friday");
        break;
        
        case "6":
        case "Six":
        Console.WriteLine("Saturday");
        break;
        
        case "7":
        case "Seven":
        Console.WriteLine("Sunday");
        break;
        
        default:
        Console.WriteLine("Invalid Number");
        break;
    }
  }
}
