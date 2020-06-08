using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Ejercicio_15
    {
        static void Main(string[] args)
        {
            bool flagSalida = true;
            string mensajeIngresado;
            int oper1;
            int oper2;
            char signoOpe;
            string resultadoStr;

            Console.Title = string.Format("Ejercicio Nº {0:##}", 15);

            do
            {
                Console.Clear();

                Console.WriteLine("Ingrese el Operando 1:");
                mensajeIngresado = Console.ReadLine();

                if (mensajeIngresado.ToLower() == "salir")
                {
                    break;
                }

                while (!int.TryParse(mensajeIngresado, out oper1))
                {
                    Console.WriteLine("Error. Debe ingresar un número:");
                    mensajeIngresado = Console.ReadLine();

                    if (mensajeIngresado.ToLower() == "salir")
                    {
                        break;
                    }
                }

                Console.WriteLine("Ingrese el Operando 2");
                mensajeIngresado = Console.ReadLine();

                if (mensajeIngresado.ToLower() == "salir")
                {
                    break;
                }

                while (!int.TryParse(mensajeIngresado, out oper2))
                {
                    Console.WriteLine("Error. Debe ingresar un número:");
                    mensajeIngresado = Console.ReadLine();

                    if (mensajeIngresado.ToLower() == "salir")
                    {
                        break;
                    }
                }

                Console.WriteLine("\n+ Suma \n- Resta \n* Multiplica \n/ Divide ");

                signoOpe = Console.ReadKey().KeyChar;

                resultadoStr = Calculadora.Calcular(oper1, oper2, signoOpe);

                Console.WriteLine("Resultado: {0} ",resultadoStr);

                Console.WriteLine("Presione una tecla para continuar...");

                Console.ReadKey();
            
            } while (flagSalida == true);
        }
    }
}
