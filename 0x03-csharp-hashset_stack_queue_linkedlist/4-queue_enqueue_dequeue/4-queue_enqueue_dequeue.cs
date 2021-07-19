using System;
using System.Collections.Generic;

    class MyQueue
    {
        public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
        {
            Console.WriteLine("Number of items: {0}", aQueue.Count);

            Console.WriteLine("First item: {0}", aQueue.Peek());

            if (aQueue.Count <= 0)
            {
                Console.WriteLine("Queue is empty");
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
            return (aQueue);
        }
    }
