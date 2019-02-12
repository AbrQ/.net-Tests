using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            //IF/ELSE

            int a = 5;
            int b = 1;

            if (a < b)
                Console.WriteLine("a is lower than b");
            else
                Console.WriteLine("a is greater than b");

            //WHILE
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("i: " +i);
                i++;
            }

            //DO/WHILE
            int j = 0;
            do
            {
                Console.WriteLine("j: " +j);
                j++;
            } while (j<11);

            //FOR

            for (int counter = 0; counter < 11; counter++)
            {
                Console.WriteLine("Counter: " +counter);
            }

            
            Console.ReadKey();
        }
    }
}
