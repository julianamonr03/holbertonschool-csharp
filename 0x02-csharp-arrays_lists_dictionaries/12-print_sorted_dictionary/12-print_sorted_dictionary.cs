using System;
using System.Collections.Generic;
using System.Linq;

    class Dictionary
    {
        public static void PrintSorted(Dictionary<string, string> myDict)
        {
            foreach (var item in myDict.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }
    }
