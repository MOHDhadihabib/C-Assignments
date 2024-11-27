/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class HelloWorld
{
    static void Main()
    {
        double balance = 1000;
        int pin = 1234;
        int enteredPin;
        bool isAuthenticated = false;

        Console.WriteLine("Welcome to the ATM!");
        Console.Write("Please enter your PIN: ");
        enteredPin = Convert.ToInt32(Console.ReadLine());

        if (enteredPin == pin)
        {
            isAuthenticated = true;
            Console.WriteLine("PIN Correct. Access granted.");
        }
        else
        {
            Console.WriteLine("Incorrect PIN. Access denied.");
            return;
        }

        while (isAuthenticated)
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your current balance is: ${balance}");
                    break;

                case 2:
                    Console.Write("Enter amount to deposit: $");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    if (depositAmount > 0)
                    {
                        balance += depositAmount;
                        Console.WriteLine($"You have successfully deposited ${depositAmount}. Your new balance is: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount! Deposit failed.");
                    }
                    break;

                case 3:
                    Console.Write("Enter amount to withdraw: $");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    if (withdrawAmount <= balance && withdrawAmount > 0)
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine($"You have successfully withdrawn ${withdrawAmount}. Your new balance is: ${balance}");
                    }
                    else if (withdrawAmount > balance)
                    {
                        Console.WriteLine("Insufficient balance!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount! Withdrawal failed.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    isAuthenticated = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
