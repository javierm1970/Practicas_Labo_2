using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    public class Ejercico_04
    {
        static void Main(string[] args)
        {
            Console.Title = string.Format("Ejercicio Nº {0:##}", 4);

            double numero=0;
            double num_Perfecto=0;
            double num_Primo;
            int Cant_Num_Perfecto=0;
            int i;
            int j;
            bool flagSalida = true;

            Console.WriteLine("NUMEROS PERFECTOS\n");

            do
            {
                numero++;

                if (Cant_Num_Perfecto >= 4)
                {
                    flagSalida = false;
                }
                else
                {
                    num_Perfecto = 0;                   
                    for (i = 1; i < numero  ; i++)
                    {
                        num_Primo = numero % i;
                        if (num_Primo == 0)
                        {
                            num_Perfecto=num_Perfecto+i;
                        }
                    }

                    if (num_Perfecto == numero)
                    {
                        Console.WriteLine(i + " Es un Numero Perfecto");
                        Cant_Num_Perfecto++;
                    }

                }

            } while (flagSalida == true);

            Console.WriteLine("Programa Terminado...");
            Console.ReadKey();
        }
    }
}
