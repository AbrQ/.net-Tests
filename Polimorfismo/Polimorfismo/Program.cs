using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();

            rectangulo.Area(20, 10);

            Triangulo triangulo = new Triangulo();

            triangulo.Area(20, 10);

            Console.ReadKey();
        }
    }
}
