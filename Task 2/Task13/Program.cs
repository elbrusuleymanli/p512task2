using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 98765;
            decimal b = 65411;
            decimal c = 32456;
           
            decimal d = 123;
            decimal e = 321;

            decimal aInt = a * 5 / 100;
            decimal bInt = a * 5 / 100;
            decimal cInt = a * 5 / 100;

            decimal multy = aInt * bInt * cInt ;

            decimal dInt = a * 3 / 100;
            decimal eInt = a * 3 / 100;

            decimal plus = dInt + eInt;

            decimal result = (plus * 10 / 100) + (multy * 10 / 100);



            Console.WriteLine(result);
        }
    }
}
