using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 12345;
            double b = 54321;
            double c = ((a+b)+500000)*10 + 5;
            double result = c * 5 / 100;

            Console.WriteLine(result);
        }
    }
}
