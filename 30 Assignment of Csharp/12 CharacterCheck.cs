using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Enter Any Alphabet:");
      string vovel = Console.ReadLine();
      
      switch(vovel){
          case "a":
          case "e":
          case "i":
          case "o":
          case "u":
          Console.WriteLine("This is vovel");
          break;
          
          default:
          Console.WriteLine("This is consonant");
          break;
      }
  }
}
