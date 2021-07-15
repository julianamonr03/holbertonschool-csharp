using System;
using System.Collections.Generic;


    class List
    {
        public static List<bool> DivisibleBy2(List<int> myList)
        {
            List<bool> new_rtn = new List<bool>();

            foreach (int each in myList)
            {
                new_rtn.Add(each % 2 == 0 ? true : false);
            }
            return (new_rtn);
        }
    }
