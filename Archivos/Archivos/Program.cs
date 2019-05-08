using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TextWriter archivo;
            archivo = new StreamWriter("archivo.txt");

            string mensaje;
            mensaje = Console.ReadLine();

            archivo.WriteLine(mensaje);
            archivo.Close();

            Console.Clear();
            Console.WriteLine("Se guardó el archivo");

            

            TextReader Leer_archivo;
            Leer_archivo = new StreamReader("archivo.txt");

            Console.WriteLine(Leer_archivo.ReadToEnd());
            Leer_archivo.Close();*/

            StreamWriter archivo;
            archivo = File.AppendText("archivo.txt");

            string mensaje;

            mensaje = Console.ReadLine();

            archivo.WriteLine(mensaje);

            archivo.Close();

            Console.ReadKey();

        }
    }
}
