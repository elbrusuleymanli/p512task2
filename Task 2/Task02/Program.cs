using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {

            int digit = 123456;
            int target = (digit -digit % 1000)/1000;
            int a = target % 10;
            int b = target % 100/10;
            int c = target % 1000/100;

            int summ = a + b + c;

            Console.WriteLine(summ);
        }
    }
}
