using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 12;
            int c = 4;

            int d = (a * b) / c;
            int e = (a * b) % c;

            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            Console.WriteLine("Integers are between: " + minInt + " and: " + maxInt);

            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;

            Console.WriteLine("Doubles are between: " + minDouble + " and: " + maxDouble);

            Console.ReadKey();
        }
    }
}
