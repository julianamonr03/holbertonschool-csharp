using System;
using System.Collections.Generic;
using System.Text;

    class LList
    {
        public static int Length(LinkedList<int> myLList)
        {
            int number = 0;

            foreach (int each in myLList)
            {
                number += 1;
            }
            return (number);
        }
    }

