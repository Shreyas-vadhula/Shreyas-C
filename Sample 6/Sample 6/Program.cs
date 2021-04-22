using System;

namespace Sample_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            Console.Write("Enter your age :");
            Age = Convert.ToInt32(Console.ReadLine());
            if (Age >= 60)
                Console.Write("You are a senior citizen"); 
            else if (Age >= 18)
                Console.Write("You are eligible to vote");
            else
                Console.Write("You are not eligible to vote");
            Console.ReadLine();
        }
    }
}