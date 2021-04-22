using System;

namespace Sample_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a "); 
            int a= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter what you want to do. \n 1. Addition \n 2.Substraction \n 3.Multiplication");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("The sum is " +(a+b));
                    break;
                case 2:
                    Console.WriteLine("The difference is " +(a-b));
                    break;
                case 3:
                    Console.WriteLine("The product is "+(a*b));
                    break;
                default:
                    Console.WriteLine("Did not select any option");
                    break;
            }
            Console.ReadLine();
        }

    }
}
