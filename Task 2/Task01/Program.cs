using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {

            int digit = 1256;
            int a = digit % 10;
            int b = digit % 100/10;
            int c = digit % 1000/100;
            int d = digit % 10000/1000;
            int summ = a+b+c+d;

            Console.WriteLine(summ);
        }
    }
}
