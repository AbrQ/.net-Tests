using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ventana calculadora = new Ventana();
            //calculadora.Mostrar();
            Console.ReadKey();
        }
    }

    class Ventana{

        //Atributos
        private int ancho, altura;
        private string color;
        //Metodos
        public Ventana()
        {
            ancho = 15;
            altura = 20;
            color = "Rojo";
            Console.WriteLine("El metodo constructor funciona");
        }

        public void Mostrar()
        {
            Console.WriteLine("La dimension de la ventana es: " + ancho + " x " + altura + " y su color es: " + color);
        }

        ~Ventana() //Metodo destructor
        {
            System.Diagnostics.Trace.WriteLine("Se destruyeron los recursos!");
        }
    }
}
