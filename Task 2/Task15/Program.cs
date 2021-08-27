using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 123;
            decimal b = 564;
            decimal c = 1234;
            decimal d = 3214;
            decimal e = 12345;
            decimal f = 54321;
            decimal g = 123456;

            decimal plus = a + b;
            decimal multy = c * d;

            decimal plus1 = plus + multy;

            decimal incr = plus1 * 10 + 7;

            decimal plus2 = e + f;
            decimal plus3 = incr + plus2;

            decimal diff = c * d * 10 + 1;

            decimal res = plus3 - diff;

            decimal plus4 = res + g;

            decimal diff1 = plus4 - (c + d + e + f);

            decimal interest = ((diff1 * 18 / 100) * 3 / 100) * 1 / 100;

            decimal result = interest + e + f;

            Console.WriteLine(result);
        }
    }
}
