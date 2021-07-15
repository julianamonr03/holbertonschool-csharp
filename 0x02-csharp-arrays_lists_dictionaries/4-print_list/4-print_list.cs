using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return (null);
            }

            List<int> new_list = new List<int>(size);

            for (int i = 0; i < size; i++)
            {
                new_list.Add(i);
            }
            Console.WriteLine(string.Join(" ", new_list));
            return (new_list);
        }
    }
