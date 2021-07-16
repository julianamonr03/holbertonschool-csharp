using System;
using System.Collections.Generic;
using System.Linq;
    class List
    {
        public static int Sum(List<int> myList)
        {
            int total = 0;

            HashSet<int> unique = new HashSet<int>(myList);

            foreach (int sum in unique)
            {
                total += sum;
            }

            return (total);
        }
    }
