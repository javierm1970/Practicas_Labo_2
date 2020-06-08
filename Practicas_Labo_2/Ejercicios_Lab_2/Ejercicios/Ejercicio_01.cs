using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class Ejercicio_01
    {
        static void Main(string[] args)
        {

            int numero;
            string mensajeIngresado;
            int total = 0;
            int numMin = 0;
            int numMax = 0;
            //float numprom = 0;

            Boolean flagPrimeraVez = true;

            Console.Title = string.Format("Ejercicio Nº {0:##}", 1); 
           
            for (int i = 0; i <= 4; i++)
            {

                Console.WriteLine("Ingrese un número:");
                mensajeIngresado = Console.ReadLine();

                if (mensajeIngresado.ToLower() == "salir")
                {
                    Environment.Exit(0);
                }

                while (!int.TryParse(mensajeIngresado, out numero))
                {
                    Console.WriteLine("Error. Debe ingresar un número:");
                    mensajeIngresado = Console.ReadLine();

                    if (mensajeIngresado.ToLower() == "salir")
                    {
                        Environment.Exit(0);
                    }
                }

                total = total + numero;

                if (flagPrimeraVez)
                {
                    numMax = numero;
                    numMin = numero;
                    flagPrimeraVez = false;
                }
                else
                {
                    if (numero > numMax)
                    {
                        numMax = numero;
                    }

                    if (numero < numMin)
                    {
                        numMin = numero;
                    }


                }

            }

            //numprom = (float) total / 5;

            Console.WriteLine("maximo: {0}  minimo: {1}  promedio: {2}", numMax, numMin, (float) total/5);

            Console.ReadKey();

        }
    }
}
