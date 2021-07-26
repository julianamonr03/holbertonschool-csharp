using System;
using System.Collections.Generic;

    class List
    {
        public static int SafePrint(List<int> myList, int n)
        {
            int number_elements = 0;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(myList[i]);
                    number_elements++; // Increment each loop for number of elements printed
                }
            }
            catch (Exception)
            {
                return(number_elements);
            }
            return (number_elements);
        }
    }

