using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Ventana calculadora = new Ventana(); //Instancia y herencia de todos los atributos y metodos de Ventana
            calculadora.Cerrar();

            Console.ReadKey();
        }
    }

    class Ventana
    {
        //Atributos
        private int ancho = 15, alto = 20;
        private string color = "Rojo";

        //Metodos
        public void Cerrar()
        {
            Console.WriteLine("La ventana se cerró");
        }

        private void Minimizar()
        {
            Console.WriteLine("La ventana se minimizó");
        }

        public void Maximizar()
        {
            Console.WriteLine("La ventana se maximizó");
        }
    }
}
