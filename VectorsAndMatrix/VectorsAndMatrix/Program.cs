using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorsAndMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unidimensional
            int[] number;
            number = new int[5];

            //Bidimensional
            int[,] matrix;
            matrix = new int[3 , 3];

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.WriteLine("Give me a number: ");
                    matrix[row, column] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.Clear();

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(" " + matrix[row, column]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
