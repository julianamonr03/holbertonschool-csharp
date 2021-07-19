using System;
using System.Collections.Generic;
using System.Linq;
    class LList
    {
        public static void Delete(LinkedList<int> myLList, int index)
        {
            LinkedListNode<int> node = myLList.First; //node to remove

            int search = 0;

            while (node != null)
            {
                if (search == index)
                {
                    myLList.Remove(node);
                }
                node = node.Next; //If not matches with index pass to next position
                search++; // increment index for search
            }
        }
    }
