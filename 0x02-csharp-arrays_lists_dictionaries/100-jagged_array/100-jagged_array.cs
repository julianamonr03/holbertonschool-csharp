using System;

namespace _100_jagged_arrayay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_array = new int[3][];

            jagged_array[0] = new int[] {0, 1, 2, 3};
            jagged_array[1] = new int[] {0, 1, 2, 3, 4, 5, 6};
            jagged_array[2] = new int[] {0, 1};


            for (int i = 0; i < jagged_array.Length; i++)
            {
                for (int j = 0; j < jagged_array[i].Length - 1; j++)
                {
                    System.Console.Write("{0} ", jagged_array[i][j]);
                }
                Console.WriteLine(jagged_array[i][jagged_array[i].Length - 1]);
            }
        }
    }
}
