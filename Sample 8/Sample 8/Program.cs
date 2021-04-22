using System;

namespace Sample_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum=0;
            Console.WriteLine("Enter the elements");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum =" + sum);
            Console.ReadLine();
        }
    }
}
