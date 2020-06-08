using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Ejercicio_26
{
    class Program
    {
        public class ReverserClass : IComparer
        {
           //Call CaseInsensitiveComparer.Compare with the parameters reversed.

           int IComparer.Compare(Object x, Object y)
            {
                return new CaseInsensitiveComparer().Compare(y, x);
            }
        }

        static void Main(string[] args)
        {

        //Crear una aplicación de consola que cargue 20 números enteros(positivos y negativos)
        //distintos de cero de forma aleatoria utilizando la clase Random.
        //a.Mostrar el vector tal como fue ingresado
        //b.Luego mostrar los positivos ordenados en forma decreciente.
        //c.Por último, mostrar los negativos ordenados en forma creciente.

        double[] numAleatorios = new double[20];
            
            Random rnd = new Random();
            double numAleaDistintoDeCero;

            for (int i = 0; i < 20; i++)
            {
                do {
                    numAleaDistintoDeCero = rnd.Next(-100, 100);
                } while (numAleaDistintoDeCero == 0);

                numAleatorios[i] = numAleaDistintoDeCero;
            }
            foreach (double item in numAleatorios)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************************************************");
            Console.WriteLine("****************************************************");
            Array.Sort(numAleatorios);

            foreach (double item in numAleatorios)
            {
                if (item >0)
                {
                    Console.WriteLine(item); 
                }
            }

            Array.Sort(numAleatorios, new ReverserClass());

            Console.WriteLine("****************************************************");

            foreach (double item in numAleatorios)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****************************************************");

            foreach (double item in numAleatorios)
            {
                if (item < 0)
                {
                    Console.WriteLine(item); 
                }
            }

            Console.ReadKey();
        }
    }
}
