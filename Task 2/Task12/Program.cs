using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 923459;
            decimal b = 756418;
            decimal c = 321457;
            decimal d = 123456;

            decimal aInt = a * 10 / 100;
            decimal bInt = b * 10 / 100;
            decimal cInt = c * 10 / 100;
            decimal dInt = d * 10 / 100;

            decimal plus1 = aInt + bInt + cInt + dInt;

            decimal aInt1 = a * 15 / 100;
            decimal bInt1 = b * 15 / 100;
            decimal cInt1 = c * 15 / 100;
            decimal dInt1 = d * 15 / 100;

            decimal plus2 = aInt1 + bInt1 + cInt1 + dInt1;

            decimal res = plus1 * plus2;

            decimal res1 = res * 10 / 100;

            decimal result = res1 * 11 / 100;

            Console.WriteLine(result);
        }
    }
}
