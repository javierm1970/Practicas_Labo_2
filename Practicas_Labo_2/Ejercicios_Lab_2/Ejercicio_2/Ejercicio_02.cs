using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    public class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = string.Format("Ejercicio Nº {0:##}", 2);

            double numero;
            double num_Cuadrado;
            double num_Cubo;
            string mensajeIngresado;
            bool flagSalida = true;

            do
            {
                Console.WriteLine("Ingrese un número:");
                mensajeIngresado = Console.ReadLine();

                if (mensajeIngresado.ToLower() == "salir")
                {
                    Environment.Exit(0);
                }

                while (!double.TryParse(mensajeIngresado, out numero))
                {
                    Console.WriteLine("Error. Debe ingresar un número:");
                    Console.WriteLine("Ingrese un número:");
                    mensajeIngresado = Console.ReadLine();

                    if (mensajeIngresado.ToLower() == "salir")
                    {
                        Environment.Exit(0);
                    }
                
                }

                if (numero < 0)
                {
                    Console.WriteLine("Error. Debe ingresar un número mayor a 0");
                }
                else
                {
                    num_Cuadrado = Math.Pow(numero, 2);
                    num_Cubo = Math.Pow(numero, 3);
                    Console.WriteLine("Numero: {0}  Cuadrado: {1}  Cubo: {2}", numero, num_Cuadrado, num_Cubo);
                }


            } while (flagSalida == true);
 
            Console.ReadKey();

        }
    }
}
