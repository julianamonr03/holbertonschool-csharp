using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int first = 0; first <= 8; first++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (first < j)
                    {
                        if (first != 8 || j != 9)
                        {
                            Console.Write("{0}{1}, ", first, j);
                        }
                        else
                        {
                            Console.WriteLine("{0}{1}", first, j);
                        }
                    }
                }
            }
        }
    }
}
