using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 92345;
            decimal b = 75641;
            decimal c = 32145;
            decimal d = 12345;

            decimal plus1 = a + c;
            decimal plus2 = b + d;
            decimal multy = plus1 * plus2;

            decimal result = multy - c * 3 / 100;

            Console.WriteLine(result);
        }
    }
}
