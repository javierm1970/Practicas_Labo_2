using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_30_Biblioteca;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia monaco = new Competencia(20, 50);
            Competencia buenosaires = new Competencia(25, 75);

            AutoF1 auto1 = new AutoF1(5, "Ferrari");
            AutoF1 auto2 = new AutoF1(6, "McLaren");
            AutoF1 auto3 = new AutoF1(7, "Lotus");
            AutoF1 auto4 = new AutoF1(8, "Williams");

            if(monaco + auto1)
            {
                Console.WriteLine("Se agrego: {0}", auto1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar: {0}", auto1.MostrarDatos());

            }

            if (monaco + auto2)
            {
                Console.WriteLine("Se agrego: {0}", auto2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar: {0}", auto2.MostrarDatos());

            }

            if (monaco + auto3)
            {
                Console.WriteLine("Se agrego: {0}", auto3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar: {0}", auto3.MostrarDatos());
            }

            if (monaco - auto2)
            {
                Console.WriteLine("Se pudo Borrar");
            }
            else
            {
                Console.WriteLine("No se pudo Borrar");
            }

            Console.WriteLine(monaco.MostrarDatos());

            Console.ReadKey();




        }
    }
}
