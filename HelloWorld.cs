using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            Console.WriteLine($"{hello.ToUpper()} {world.ToLower()}");
            Console.ReadKey();
        }
    }
}
