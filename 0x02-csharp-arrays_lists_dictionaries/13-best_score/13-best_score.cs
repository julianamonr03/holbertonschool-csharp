using System;
using System.Collections.Generic;
using System.Linq;


    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
            if (myList.Count == 0)
            {
                return ("None");
            }

            // c => comparision value, s => selected element
            var max = myList.Aggregate((c, s) => c.Value > s.Value ? c : s).Key;
            // loops over each element and comparison function that returns the bigger value
            return (max);
        }
    }
