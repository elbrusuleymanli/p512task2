using System;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 12345678;
            int lCut = digit / 10;
            int fCut = lCut % 1000000;


            Console.WriteLine(fCut);
        }
    }
}
