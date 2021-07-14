using System;

    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size == 0)
            {
                Console.WriteLine("");
                return new int[0];
            }
            else if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return (null);
            }

            int[] new_array = new int[size];

            for (int number = 0; number < size; number++)
            {
                new_array[number] = number;
            }
            Console.WriteLine(string.Join(" ", new_array));
                return (new_array);
        }
    }
