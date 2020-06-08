using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribir un programa que determine si un año es bisiesto. 
 * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, 
 * salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
 * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
 * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%). 
 
 */

namespace Ejercicio_06
{
    public class Ejercicio_06
    {
        static void Main(string[] args)
        {

            Console.Title = string.Format("Ejercicio Nº {0:##}", 6);

            int anio_Desde;
            int anio_Hasta;
            bool flagSalida = true;

            string mensajeIngresado;

            do
            { 
                Console.WriteLine("Ingrese desde que año: ");

                mensajeIngresado = Console.ReadLine();

                if (mensajeIngresado.ToLower() == "salir")
                {
                    Environment.Exit(0);
                }

                while (!int.TryParse(mensajeIngresado, out anio_Desde))
                {
                    Console.WriteLine("Error. Debe ingresar desde que anio:");
                    mensajeIngresado = Console.ReadLine();

                    if (mensajeIngresado.ToLower() == "salir")
                    {
                        Environment.Exit(0);
                    }
                }

                Console.WriteLine("Ingrese Hasta que año: ");

                mensajeIngresado = Console.ReadLine();

                if (mensajeIngresado.ToLower() == "salir")
                {
                    Environment.Exit(0);
                }

                while (!int.TryParse(mensajeIngresado, out anio_Hasta))
                {
                    Console.WriteLine("Error. Debe ingresar hasta que anio:");
                    mensajeIngresado = Console.ReadLine();

                    if (mensajeIngresado.ToLower() == "salir")
                    {
                        Environment.Exit(0);
                    }

                }

                if (anio_Hasta <= anio_Desde)
                {
                    Console.WriteLine("Error. El anio hasta, debe ser mayor al anio desde... reintente");
                }
                else
                {
                    for (int i = anio_Desde; i <= anio_Hasta; i++)
                    {
                        if (i % 4 == 0 && i % 100 != 0)
                        {
                            Console.WriteLine("{0}  Es Bisiesto",i);
                        } 
                        else if (i % 4 == 0 && i % 100 == 0 && i % 400 == 0) 
                        {
                            Console.WriteLine("{0}  Es Bisiesto",i);
                        }

                    }
                }

            }while(flagSalida==true);

            Console.ReadKey();
        }
    }
}
