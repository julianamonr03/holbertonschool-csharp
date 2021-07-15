using System;
using System.Collections.Generic;


    class Dictionary
    {
        public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
        {
            Dictionary<string, int> new_double = new Dictionary<string, int>();

            foreach (var each in myDict)
            {
                new_double[each.Key] = each.Value * 2;
            }
            return (new_double);
        }
    }

