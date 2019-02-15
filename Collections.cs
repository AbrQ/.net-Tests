using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Collections
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Abraham", "Ana", "Felipe" };

            //Adding names
            names.Add("Valentin");

            //Removing names
            names.Remove(names[0]);

            //Index of
            var index = names.IndexOf("Ana");

            if (index != -1){
                Console.WriteLine($"The index position for {names[index]} is {index + 1}");
            }

            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //FIBONACCI SERIES
            Console.WriteLine("Fibonacci Series");

            var fibonaciNumbers = new List<int> {1,1};
            var previous = fibonaciNumbers[fibonaciNumbers.Count - 1];
            var previousTwo = fibonaciNumbers[fibonaciNumbers.Count - 2];

            fibonaciNumbers.Add(previous + previousTwo);

            foreach (var item in fibonaciNumbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
