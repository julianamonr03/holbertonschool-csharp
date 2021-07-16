using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> DifferentElements(List<int> list1, List<int> list2)
        {
            List<int> tmp = new List<int>();
            List<int> common = new List<int>();

            tmp = list1.FindAll(x => !list2.Contains(x));
            common = list2.FindAll(x => !list1.Contains(x));

            common.AddRange(tmp);
            common.Sort();
            return (common);
        }
    }

