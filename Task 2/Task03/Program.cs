using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 612156248;

            int a = digit % 1000000/1000;

            int fdig = a % 10;
            int sdig = a % 100/10;
            int tdig = a % 1000 / 100;

            int sum = fdig + sdig + tdig ;


            Console.WriteLine(sum);
        }
    }
}
