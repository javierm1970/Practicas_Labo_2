using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_33_Biblioteca;

namespace Ejercicio_33_Bis
{
    class Program
    {
        static void Main(string[] args)
        {

            Libro l1 = new Libro();

            l1[0] = "pagina 0";
            l1[1] = "pagina 1";
            l1[2] = "pagina 2";

            l1[1] = "pagina 5";

            for (int i = 0; i < l1.PropiedadCoutn;i++)
            {
                Console.WriteLine("{0}   {1}    {2}", l1[i], l1.PropiedadCoutn,i); 
            }                

            Console.ReadKey();
        }
    }
}
