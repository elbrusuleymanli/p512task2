using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 9234;
            double b = 4321;
            double c = 1789;

            double first = a * 1 / 100;
            double second = b * 2 / 100;
            double third = c * 3 / 100;

            double diff = first - second - third;

            double result = diff + c * 7 / 100;

            Console.WriteLine(result);
        }
    }
}
