﻿using System;
using System.Collections.Generic;
using System.Linq;

    class LList
    {
        public static int Sum(LinkedList<int> myLList)
        {
            int sum = 0;
            foreach (var num in myLList)
            {
                sum += num;
            }
            return (sum);
        }
    }
