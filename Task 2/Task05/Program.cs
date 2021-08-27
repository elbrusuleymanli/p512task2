using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {

            int digit = 025623;
            int fdig = digit % 1000000 / 100000;
            int firstCut = digit % 100000;
            int lastAdd = firstCut * 10 + fdig;

            Console.WriteLine(lastAdd);
        }
    }
}
