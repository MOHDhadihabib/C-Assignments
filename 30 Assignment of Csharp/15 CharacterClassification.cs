using System;

class HelloWorld {
    static void Main() {
        Console.Write("Enter Any Character: ");
        
        string input = Console.ReadLine();
        
        if (input.Length > 0) {
            char inputChar = input[0];

            if (Char.IsUpper(inputChar)) {
                Console.WriteLine("The Character is in UpperCase");
            } 
            else if (Char.IsLower(inputChar)) {
                Console.WriteLine("The Character is in LowerCase");
            }
            else if (Char.IsDigit(inputChar)) {
                Console.WriteLine("The Character is in Digit");
            }
            else {
                Console.WriteLine("The Character is a Special Character");
            }
        } 
        else {
            Console.WriteLine("No character was entered.");
        }
    }
}
