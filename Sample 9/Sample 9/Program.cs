using System;

namespace Sample_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Console.WriteLine("Enter the elements");

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for(int col = 0; col < arr.GetLength(0); col++)
                    {
                     arr[row, col] = Convert.ToInt32(Console.ReadLine());
                    }
            }
            Console.WriteLine("\n-------------Before Transpose---------------\n");
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(0); col++)
                {
                    Console.Write(arr[row,col] + "\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n-------------After Transpose---------------\n");
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write(arr[col, row] + "\t");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

        }
    }
}
