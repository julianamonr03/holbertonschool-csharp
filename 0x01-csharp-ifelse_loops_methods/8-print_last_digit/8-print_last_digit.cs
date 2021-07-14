using System;

    class Number
    {
        public static int PrintLastDigit(int number)
        {
            int last = 0;

            if (number < 0)
            {
                last = ((number % 10) * - 1);
            }
            else
            {
                last = number % 10;
            }
            Console.Write(last);
            return (last);
        }
    }
