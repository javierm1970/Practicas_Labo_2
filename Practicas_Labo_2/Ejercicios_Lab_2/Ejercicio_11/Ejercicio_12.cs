using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public class Ejercicio_12
    {
        static void Main(string[] args)
        {
            int numero;
            int total=0;
            int suma = 0;
            char respu;
            bool flagSalida = true;
            string mensajeIngresado;

            Console.Title = string.Format("Ejercicio Nº {0:##}", 12);

            do
            {
                Console.WriteLine("\nIngrese un número:");
                mensajeIngresado = Console.ReadLine();

                while (!int.TryParse(mensajeIngresado, out numero))
                {
                    Console.WriteLine("\nError. Debe ingresar un número:");
                    mensajeIngresado = Console.ReadLine();

                }

                total= suma + numero;

                Console.WriteLine("{0} + {1} = {2}",numero,suma,total);

                suma = suma + numero;

                Console.WriteLine("\nSigue ingrasando numeros a Sumar? S/N");
                
                respu =Console.ReadKey().KeyChar;
                
                if (ValidarRespuesta.ValidaS_N(respu))
                {
                    continue;
                }

                flagSalida=false;

            } while (flagSalida == true);
            
        }
    }
}
