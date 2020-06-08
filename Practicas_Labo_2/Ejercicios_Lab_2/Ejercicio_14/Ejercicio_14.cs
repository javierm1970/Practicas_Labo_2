using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            string mensajeIngresado;
            double lado;
            double baseTriang;
            double altura;
            double radio;
            char opcion;
            bool flagSalida = true;


            Console.Title = string.Format("Ejercicio Nº {0:##}", 14);

            do
            {
                Console.Clear();
                Console.WriteLine("1- Area de un Cuadrado");
                Console.WriteLine("2- Area de un Triangulo");
                Console.WriteLine("3- Area de un Circulo");
                Console.WriteLine("s- Salida");                
                
                opcion = Console.ReadKey().KeyChar;                
                
                switch (opcion)
                {
                    case '1':
                        Console.WriteLine("Ingrese Lado del Cuadrado:");
                        mensajeIngresado = Console.ReadLine();

                        if (mensajeIngresado.ToLower() == "salir")
                        {
                            break;
                        }

                        while (!double.TryParse(mensajeIngresado, out lado))
                        {
                            Console.WriteLine("Error. Debe ingresar un número:");
                            mensajeIngresado = Console.ReadLine();

                            if (mensajeIngresado.ToLower() == "salir")
                            {
                                break;
                            }
                        }

                        Console.WriteLine("El Area del Cuadrado es: {0} ", CalculoDeArea.CalcularCuadrado(lado));
                        
                        break;
                    case '2':
                        Console.WriteLine("Ingrese Base del Triangulo:");
                        mensajeIngresado = Console.ReadLine();

                        if (mensajeIngresado.ToLower() == "salir")
                        {
                            break;
                        }

                        while (!double.TryParse(mensajeIngresado, out baseTriang))
                        {
                            Console.WriteLine("Error. Debe ingresar un número:");
                            mensajeIngresado = Console.ReadLine();

                            if (mensajeIngresado.ToLower() == "salir")
                            {
                                break;
                            }
                        }

                        Console.WriteLine("Ingrese Altura del Triangulo:");
                        mensajeIngresado = Console.ReadLine();

                        if (mensajeIngresado.ToLower() == "salir")
                        {
                            break;
                        }

                        while (!double.TryParse(mensajeIngresado, out altura))
                        {
                            Console.WriteLine("Error. Debe ingresar un número:");
                            mensajeIngresado = Console.ReadLine();

                            if (mensajeIngresado.ToLower() == "salir")
                            {
                                break;
                            }
                        }

                        Console.WriteLine("El Area del Triangulo es: {0} ", CalculoDeArea.CalcularTriangulo(baseTriang, altura));


                        break;
                    case '3':
                        Console.WriteLine("Ingrese el Radio del Circulo:");
                        mensajeIngresado = Console.ReadLine();

                        if (mensajeIngresado.ToLower() == "salir")
                        {
                            break;
                        }

                        while (!double.TryParse(mensajeIngresado, out radio))
                        {
                            Console.WriteLine("Error. Debe ingresar un número:");
                            mensajeIngresado = Console.ReadLine();

                            if (mensajeIngresado.ToLower() == "salir")
                            {
                                break;
                            }
                        }

                        Console.WriteLine("El Area del Circulo es: {0} ", CalculoDeArea.CalcularCirculo(radio));

                        break;
                    default:
                        if (opcion == 's' || opcion == 'S')
                        {
                            Environment.Exit(0);
                        }
                        break;

                }

                Console.ReadKey();

            } while (flagSalida == true);
        }
    }
}
