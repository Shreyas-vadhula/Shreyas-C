using System;

namespace Sample_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Console.Write("Enter a number :");
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
                Console.Write(Number + " is divisible by 2");
            else if(Number % 3 == 0)
                Console.Write(Number + " is divisible by 3");
            else if (Number % 5 == 0)
                Console.Write(Number + " is divisible by 5");
            else 
                Console.Write(Number + " is not divisible by 2, 3 and 5");
            Console.ReadLine();
        }
    }
}
