using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);

        int last = number % 10;

        // if (number < 0)
        //{
        //    last = number % (-10);
        //}

        Console.Write("The last digit of {0} is ", number);

        if (last > 5)
        {
          Console.WriteLine("{0} and is greater than 5", last);
        }
        if (last == 0)
        {
          Console.WriteLine("{0} and is 0", last);
        }
        else if (last < 6)
        {
          Console.WriteLine("{0} and is less than 6 and not 0", last);
        }
    }
}
