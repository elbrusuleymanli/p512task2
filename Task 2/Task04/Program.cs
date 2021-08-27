using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 12345;
            int last = digit % 10;
            int first = digit % 100000 / 10000;
            int sum = last + first;
            int result = sum * sum;


            
            Console.WriteLine(result);
        }
    }
}
