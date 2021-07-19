using System;
using System.Collections.Generic;

    class LList
    {
        public static int FindNode(LinkedList<int> myLList, int value)
        {
            int position = 0;

            foreach (int each in myLList)
            {
                if (each == value)
                {
                    return (position);
                }
                position++; // increment in every loop == index
            }
            return (-1); // if value not in the list return -1
        }
    }
