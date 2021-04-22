using System;

namespace Sample11
{
    public enum Salutation
    {
        Mr = 0,
        Ms = 1,
        Mrs = 2,
        Dr = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Salutation salutation;
            string name;
            Console.WriteLine("Enter the Salutaion");
            salutation = (Salutation)Enum.Parse(typeof(Salutation), Console.ReadLine());
            Console.WriteLine("Enter your name ");
            name = Console.ReadLine();
            Console.WriteLine("\n Your name is :{0}", salutation.ToString()+ "." + name);


        }
    }
}
