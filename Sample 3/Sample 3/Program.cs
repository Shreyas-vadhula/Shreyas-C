using System;

namespace Sample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, result;
            Console.Write("Enter First Number :");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Second Number :"); 
            secondNumber = Convert.ToInt32(Console.ReadLine());
            result = firstNumber + secondNumber;
            Console.WriteLine("\nThe sum of the numbers is :" + result);
            Console.ReadLine();

        }
    }
}
