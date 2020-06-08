using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_17_2;

namespace Ejercicio_17
{
    class Ejercicio_17
    {
        static void Main(string[] args)
        {

            Console.Title = string.Format("Ejercicio Nº {0:##}", 17);

            Boligrafo boliAzul = new Boligrafo(100);
            Boligrafo boliRojo = new Boligrafo(50);

            ConsoleColor color = new ConsoleColor();

            Console.WriteLine("Cantidad de Tinta // Azul: {0}  Rojo: {1}", boliAzul.GetTinta(), boliRojo.GetTinta());
            Console.ReadKey();


            for(int i = 0; i < 4; i++)
            {
                string cuantoPinto;
                bool pudoPintar;

                color = boliRojo.GetColor("rojo");
                Console.ForegroundColor = color;
                pudoPintar = boliRojo.Pintar(20, out cuantoPinto);

                Console.WriteLine("Rojo\nCuanto pudo pintar?  {0}", cuantoPinto + " " + "( " + cuantoPinto.Length + " )");
                Console.WriteLine("Cuanta Tinta tiene el boligrafo Rojo?   {0}", boliRojo.GetTinta());


                color = boliRojo.GetColor("azul");
                Console.ForegroundColor = color;
                pudoPintar = boliAzul.Pintar(43, out cuantoPinto);

                Console.WriteLine("Azul\nCuanto pudo pintar?  {0}", cuantoPinto + " " + "( " + cuantoPinto.Length + " )");
                Console.WriteLine("Cuanta Tinta tiene el boligrafo Azul?  {0}", boliAzul.GetTinta());


                Console.ReadKey();
        
            }
        }
    }
}
