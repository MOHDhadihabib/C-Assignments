using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter First Number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter Second Number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter Third Number");
    int num3 = Convert.ToInt32(Console.ReadLine());
    
    if(num1<num2){
        if(num1<num3){
            Console.WriteLine("The smallest Number is " + num1);
        }
        else
        {Console.WriteLine("The smallest Number is " + num3);}
    }
    else{
         if(num2<num3){
            Console.WriteLine("The smallest Number is " + num2);
        }
        else
        {Console.WriteLine("The smallest Number is " + num3);}
    }
  }
}
