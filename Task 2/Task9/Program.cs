using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 123456;
            double b = 654321;
            double c = 123450;
            double d = ((a * 10 / 100) + (b * 10 / 100) + (c * 10 / 100)) * 10 / 100;
            
            Console.WriteLine(d);
        }
    }
}
