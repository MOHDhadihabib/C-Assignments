/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class HelloWorld {
    static void Main() {
        Console.WriteLine("Currency Converter");

        Console.Write("Enter your Currency (USD, EUR, GBP): ");
        string yourcurrency = Console.ReadLine().ToUpper();

        Console.Write("Tell me the currency in which you want to convert (USD, EUR, GBP): ");
        string concurrency = Console.ReadLine().ToUpper();

        Console.Write("Enter Your Amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        decimal convertedAmount = 0;

        string conversionkey = yourcurrency + "TO" + concurrency;

        switch(conversionkey) {
            case "USDTOEUR":
                convertedAmount = amount * 0.92m;
                break;
            case "USDTOGBP":
                convertedAmount = amount * 0.82m;
                break;
            case "EURTOUSD":
                convertedAmount = amount * 1.09m;
                break;
            case "EURTOGBP":
                convertedAmount = amount * 0.89m;
                break;
            case "GBPTOUSD":
                convertedAmount = amount * 1.22m;
                break;
            case "GBPTOEUR":
                convertedAmount = amount * 1.12m;
                break;
            default:
                Console.WriteLine("Invalid currency conversion.");
                return;
        }

        Console.WriteLine($"Converted Amount: {convertedAmount} {concurrency}");
    }
}
