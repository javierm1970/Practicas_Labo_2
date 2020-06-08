using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_53_Interfaz;

namespace Ejercicio_53_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Lapiz lapiz1 = new Lapiz(10);
            Lapiz lapiz2 = new Lapiz(12);
            Lapiz lapiz3 = new Lapiz(14);
            Lapiz lapiz4 = new Lapiz(16);
            Lapiz lapiz5 = new Lapiz(18);
            Lapiz lapiz6 = new Lapiz(20);

            Boligrafo boli1 = new Boligrafo(10,ConsoleColor.Blue);
            Boligrafo boli2 = new Boligrafo(12,ConsoleColor.Blue);
            Boligrafo boli3 = new Boligrafo(14,ConsoleColor.Blue);
            Boligrafo boli4 = new Boligrafo(16,ConsoleColor.Blue);
            Boligrafo boli5 = new Boligrafo(18,ConsoleColor.Blue);
            Boligrafo boli6 = new Boligrafo(20,ConsoleColor.Blue);


            Cartuchera1 cartuchera1 = new Cartuchera1();

            cartuchera1.utiles.Add(lapiz1);
            cartuchera1.utiles.Add(lapiz3);
            cartuchera1.utiles.Add(boli1);
            cartuchera1.utiles.Add(boli3);


            Cartuchera2 cartuchera2 = new Cartuchera2();

            cartuchera2.boligrafos.Add(boli2);
            cartuchera2.boligrafos.Add(boli4);
            cartuchera2.boligrafos.Add(boli6);

            cartuchera2.lapices.Add(lapiz2);
            cartuchera2.lapices.Add(lapiz4);
            cartuchera2.lapices.Add(lapiz6);

            bool retorno = true;
            bool retorno2 = true;

            do
            {
                if (!(cartuchera1.ProbarElementos()))
                {
                    retorno = false;
                }

                if (!(cartuchera2.ProbarElementos()))
                {
                    retorno2 = false;
                }


            } while (retorno==true && retorno2==true);

            foreach (IAcciones item in cartuchera1.utiles)
            {
                Console.WriteLine("Cartuchera1 /// Nivel de escritura: {0} - Color: {1}",
                    item.UnidadDeEscritura, item.Color);
            }
            foreach (Lapiz item in cartuchera2.lapices)
            {
                Console.WriteLine("Cartuchera2 lapices /// Nivel de escritura: {0} - Color: {1}",
                    ((IAcciones)item).UnidadDeEscritura, ((IAcciones)item).Color);
            }
            foreach (Boligrafo item in cartuchera2.boligrafos)
            {
                Console.WriteLine("Cartuchera2 Boligrafos /// Nivel de escritura: {0} - Color: {1}", item.UnidadDeEscritura, item.Color);
            }
            Console.WriteLine("Cartuchera1: {0} / Cartuchera2: {1}", retorno, retorno2);
            Console.ReadKey();

            //ConsoleColor colorOriginal = Console.ForegroundColor;
            //Lapiz miLapiz = new Lapiz(10);
            //Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            //EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            //Console.ForegroundColor = eLapiz.color;
            //Console.WriteLine(eLapiz.texto);
            //Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miLapiz);
            //EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            //Console.ForegroundColor = eBoligrafo.color;
            //Console.WriteLine(eBoligrafo.texto);
            //Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miBoligrafo);

            //Console.ReadKey();
        }
    }
}
