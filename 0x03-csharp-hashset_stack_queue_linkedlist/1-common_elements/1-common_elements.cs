using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> CommonElements(List<int> list1, List<int> list2)
        {
            List<int> common_sorted = new List<int>();

            common_sorted = list1.FindAll(x => list2.Contains(x));
            // Retrieves elms that match the conditions define
            // and returns a bool if elm is in the list
            return (common_sorted);
        }
    }
