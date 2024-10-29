using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Main prueba = new Main();

            string input = Console.ReadLine();
            Console.WriteLine(prueba.ValSeleccion(input));
            Console.ReadKey();
        }
    }
}
