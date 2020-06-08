using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_36_Biblioteca;
using Ejercicio_36_Herencia;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia monaco = new Competencia(20, 50, Competencia.TipoVehiculo.AutosF1);
            Competencia buenosaires = new Competencia(25, 75, Competencia.TipoVehiculo.AutosF1);

            AutoF1 auto1 = new AutoF1(5, "Ferrari",500);
            AutoF1 auto2 = new AutoF1(6, "McLaren",500);
            AutoF1 auto3 = new AutoF1(7, "Lotus",500);
            AutoF1 auto4 = new AutoF1(8, "Williams",500);

            Competencia monacoMoto = new Competencia(20, 50, Competencia.TipoVehiculo.MotoCross);
            Competencia buenosairesMoto = new Competencia(25, 75, Competencia.TipoVehiculo.MotoCross);

            
            MotoCross moto1 = new MotoCross(5, "Honda", 750);
            MotoCross moto2 = new MotoCross(6, "Gillera", 750);
            MotoCross moto3 = new MotoCross(7, "Kawhasaky", 750);
            MotoCross moto4 = new MotoCross(8, "VMW", 750);

            bool pudo = (monacoMoto + moto1);
            pudo = (monacoMoto + moto2);
            pudo = (monacoMoto + moto3);
            pudo = (monacoMoto + moto4);

            pudo = (buenosairesMoto + moto1);
            pudo = (buenosairesMoto + moto2);
            pudo = (buenosairesMoto + moto3);
            pudo = (buenosairesMoto + moto4);

            Console.WriteLine(monacoMoto.MostrarDatos());
            Console.ReadKey();


            if (monaco + auto1)
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
