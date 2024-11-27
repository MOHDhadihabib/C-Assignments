/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
  Console.WriteLine("Enter a word or number:");
        string input = Console.ReadLine();
        
        string str = input.ToLower();
        int length = str.Length;
        
        bool isPalindrome = true;

        if (length == 0)
        {
            isPalindrome = false;
        }
        else
        {
            if (str[0] != str[length - 1])
            {
                isPalindrome = false;
            }
            else
            {
                if (length == 1)
                {
                    isPalindrome = true;
                }
                else
                {
                    if (str[1] != str[length - 2])
                    {
                        isPalindrome = false;
                    }
                    else
                    {
                        if (length == 2)
                        {
                            isPalindrome = true;
                        }
                        else
                        {
                            if (str[2] != str[length - 3])
                            {
                                isPalindrome = false;
                            }
                            else
                            {
                                if (length == 3)
                                {
                                    isPalindrome = true;
                                }
                                else
                                {
                                    if (str[3] != str[length - 4])
                                    {
                                        isPalindrome = false;
                                    }
                                    else
                                    {
                                        if (length == 4)
                                        {
                                            isPalindrome = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("The input is a palindrome.");
        }
        else
        {
            Console.WriteLine("The input is not a palindrome.");
        }   }
}