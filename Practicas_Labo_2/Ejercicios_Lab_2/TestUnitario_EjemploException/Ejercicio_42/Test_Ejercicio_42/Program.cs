using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception_Ejercicio_45;
namespace Test_Ejercicio_45
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase aux = new OtraClase();
                aux.MetodoDeInstancia();
            }
            catch (MiExcepcion e)
            {
                //e.	MiException será capturada en el Main,
                // mostrando el mensaje de error que esta almacena por pantalla
                // y los mensajes de todas las excepciones almacenadas en sus innerException.
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.ReadKey();

                if (!(e.InnerException is null))
                {
                    Exception ex = e.InnerException;
                    do
                    {
                        Console.WriteLine(ex.Message);
                        ex = ex.InnerException;

                    } while (!(ex is null));
                }
                //if (!object.ReferenceEquals(e.InnerException, null))
                //{
                //    Exception ex = e.InnerException;
                //    do
                //    {
                //        Console.WriteLine(ex.Message);
                //        ex = ex.InnerException;
                //    } while (!object.ReferenceEquals(ex, null));
                //}
            }

            Console.ReadKey();
        }
    }
}
