using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    public class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = string.Format("Ejercicio Nº {0:##}", 3);

            double numero;
            double num_Primo;
            int cant_divisiones=0;
            //double num_Cubo;
            string mensajeIngresado;
            string resultado;
            int i;
            int j;
            bool flagSalida = true;

            Console.WriteLine("NUMEROS PRIMOS\n");           

            do
            {
                Console.WriteLine("Ingrese un número mayor a 1:");
                mensajeIngresado = Console.ReadLine();

                if (mensajeIngresado.ToLower() == "salir")
                {
                    Environment.Exit(0);
                }

                while (!double.TryParse(mensajeIngresado, out numero))
                {
                    Console.WriteLine("Error. Debe ingresar un número mayor a 1:");
                    Console.WriteLine("Ingrese un número:");
                    mensajeIngresado = Console.ReadLine();

                    if (mensajeIngresado.ToLower() == "salir")
                    {
                        Environment.Exit(0);
                    }

                }

                if (numero <= 1)
                {
                    Console.WriteLine("Error. Debe ingresar un número mayor a 1");
                }
                else
                {
                    for (i= 1; i <= numero; i++){

                        cant_divisiones = 0;

                        for (j=1; j<=i;j++)
                        {
                            num_Primo = i % j;
                            if (num_Primo == 0)
                            {
                                cant_divisiones++;
                            }
                        }

                        if (cant_divisiones == 2)
                        {
                            Console.WriteLine(i+" Es Primo");
                        }
                        





 
                    }
                    
                    //num_Cuadrado = Math.Pow(numero, 2);
                    //num_Cubo = Math.Pow(numero, 3);
                    //Console.WriteLine("Numero: {0}  Cuadrado: {1}  Cubo: {2}", numero, num_Cuadrado, num_Cubo);
                }


            } while (flagSalida == true);

            Console.ReadKey();

        }
    }
}
