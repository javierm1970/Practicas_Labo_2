using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio_11
{
    public class Ejercicio_11
    {
        static void Main(string[] args)
        {

            int numero;
            string mensajeIngresado;
            int total = 0;
            int numMin = 0;
            int numMax = 0;
            int i = 0;
            Boolean flagPrimeraVez = true;

            Console.Title = string.Format("Ejercicio Nº {0:##}", 11);

            //Validacion num_validado = new Validacion();
            
            //for (int i = 0; i <= 9; i++)
            while (i<=9)
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

                if (!Validacion.Validar(numero, -100, 100))
                {
                    Console.WriteLine("Error. Rango entre -100 y 100");
                }
                else
                {
                    i++;
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

            }

            Console.WriteLine("maximo: {0}  minimo: {1}  promedio: {2}", numMax, numMin, (float) total/10);

            Console.ReadKey();

        }
    }
}
