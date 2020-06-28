using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_72;

namespace Ejercicio_72_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string auxLong;
            long numeroLong;
            
            do
            {
                Console.Write("Ingrese un número: "); 
                auxLong = Console.ReadLine();

                if (long.TryParse(auxLong,out numeroLong))
                {
                    Console.WriteLine("Número de          {0}",
                        numeroLong.CantidadDigitosLong());  
                }
            } while (!(auxLong ==""));
        }
    }
}
