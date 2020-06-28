using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_73;

namespace Ejercicio_73_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string auxString;
            Console.Write("Ingrese una oración: ");
            auxString = Console.ReadLine();

            Console.WriteLine(auxString.CuentaSignosPuntuacion());
            Console.ReadKey();

        }
    }
}
