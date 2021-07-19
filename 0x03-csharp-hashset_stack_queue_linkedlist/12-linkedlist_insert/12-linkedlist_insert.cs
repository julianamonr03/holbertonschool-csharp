using System;
using System.Linq;
using System.Collections.Generic;

    class LList
    {
        public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
        {
            LinkedListNode<int> node = myLList.First;

            while (node != null)
            {
                if (node.Value < n)
                {
                    node = node.Next;
                }
                else
                {
                    myLList.AddBefore(node, n);
                    return (node);
                }
            }
            myLList.AddLast(n);
            return (myLList.First);
        }
    }

