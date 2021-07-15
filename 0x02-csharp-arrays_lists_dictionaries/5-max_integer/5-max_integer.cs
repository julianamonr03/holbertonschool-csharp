using System;
using System.Collections.Generic;

    class List
    {
        public static int MaxInteger(List<int> myList)
        {
            if (myList == null)
            {
                Console.WriteLine("List is empty");
                return (-1);
            }
            myList.Sort();
            int max = myList[myList.Count - 1];
            return (max);
        }
    }
