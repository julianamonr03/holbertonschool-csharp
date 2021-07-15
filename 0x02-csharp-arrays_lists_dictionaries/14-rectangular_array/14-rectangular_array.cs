using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array_D = new int[5, 5];

            array_D[2, 2] = 1;

            for (int i = 0; i < array_D.GetLength(0); i++)
            {
                for (int j = 0; j < array_D.GetLength(1); j++)
                {
                    Console.Write("{0} ", array_D[i,j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
