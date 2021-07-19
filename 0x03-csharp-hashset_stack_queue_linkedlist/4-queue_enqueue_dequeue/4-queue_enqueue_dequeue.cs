using System;
using System.Collections.Generic;

    class MyQueue
    {
        public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
        {
            Console.WriteLine("Number of items: {0}", aQueue.Count);

            if (aQueue.Count <= 0)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("First item: {0}", aQueue.Peek());
            }

            aQueue.Enqueue(newItem);
            bool answer = aQueue.Contains(search);

            if (aQueue.Contains(search))
            {
                Console.WriteLine("Queue contains \"{0}\": {1}", search, answer);

                while (aQueue.Contains(search))
                {
                    aQueue.Dequeue();
                }
            }
            else
            {
                Console.WriteLine("Queue contains \"{0}\": {1}", search, answer);
            }
            return (aQueue);
        }
    }
