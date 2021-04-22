using System;

namespace Sample_4
{   
    class Program
    {
        static void Main(string[] args)
        {
            int enterAge;
            Console.WriteLine("Enter your Age :");
            enterAge = Convert.ToInt32(Console.ReadLine());

            if (enterAge >=18)
                Console.WriteLine("Person is able to vote.");
            else
                Console.WriteLine("Person is not able to vote.");
            Console.ReadLine();
        }
    }
}
