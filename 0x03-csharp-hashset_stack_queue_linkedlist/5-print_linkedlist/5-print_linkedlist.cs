using System;
using System.Collections.Generic;
using System.Text;

    class LList
    {
        public static LinkedList<int> CreatePrint(int size)
        {
            LinkedList<int> new_linked = new LinkedList<int>();

            if (size <= 0)
            {
                return (new_linked);
            }

            for (int i = 0; i < size ; i++)
            {
                new_linked.AddFirst(i);
                Console.WriteLine(i);
            }
            return (new_linked);
        }
    }
