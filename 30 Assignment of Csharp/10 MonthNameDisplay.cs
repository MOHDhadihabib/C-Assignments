using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter any Number from 1 to 12 ");
    string Number = Console.ReadLine();
    
    switch(Number){
        case "1":
        case "One":
        Console.WriteLine("Janurary");
        break;
                
        case "2":
        case "Two":
        Console.WriteLine("Feburary");
        break;
        
        case "3":
        case "Three":
        Console.WriteLine("March");
        break;
        
        case "4":
        case "Four":
        Console.WriteLine("April");
        break;
        
        case "5":
        case "Five":
        Console.WriteLine("May");
        break;
        
        case "6":
        case "Six":
        Console.WriteLine("June");
        break;
        
        case "7":
        case "Seven":
        Console.WriteLine("July");
        break;
        
        case "8":
        case "Eight":
        Console.WriteLine("Augest");
        break;
        
        case "9":
        case "Nine":
        Console.WriteLine("September");
        break;
        
        case "10":
        case "Ten":
        Console.WriteLine("October");
        break;
        
        case "11":
        case "Eleven":
        Console.WriteLine("Novemeber");
        break;
        
        case "12":
        case "Twelve":
        Console.WriteLine("December");
        break;
        
        default:
        Console.WriteLine("Invalid Number");
        break;
    }
  }
}
