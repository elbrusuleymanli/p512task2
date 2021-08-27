using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1234;
            double b = 1234567;
            double fisrtDigit = a * 4 / 100;
            double secondDigit = b * 9 / 100;
            double result = (fisrtDigit + secondDigit) * 10 / 100;


            Console.WriteLine(result);
        }
    }
}
