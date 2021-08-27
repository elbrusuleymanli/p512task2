using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 923459;
            decimal b = 756418;
            decimal c = 321457;
            decimal d = 123456;
            decimal e = 121457;
            decimal f = 123455;

            decimal plus = a + b + c + d + e + f;

            decimal stick = a * 1000000 + c;

            decimal diff = plus - stick;

            decimal res = diff * 10 / 100;

            decimal result = (res + e + f) * 11 / 100;

            Console.WriteLine(result);
        }
    }
}
