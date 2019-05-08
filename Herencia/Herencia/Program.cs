using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Hijo herencia = new Hijo();
            herencia.Saludar();
            herencia.Despedirse();

            Console.ReadKey();
        }
    }
}
