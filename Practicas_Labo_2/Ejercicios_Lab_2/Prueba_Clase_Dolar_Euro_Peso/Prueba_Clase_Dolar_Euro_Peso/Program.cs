using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Prueba_Clase_Dolar_Euro_Peso
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro eu1 = 100;
            Dolar do1 = 100;
            Peso pe1 = 100;

            //Console.WriteLine("{0}   {1}   {2}  ", do1.GetCantidad(), eu1.GetCantidad(), pe1.GetCantidad());

            //Euro eu2 = 100;
            //Dolar do2 = 116;
            //Peso pe2 = 100*38.33;

            //Console.WriteLine("dolar: {0}   Euro: {1}   {2}",do2.GetCantidad(),eu2.GetCantidad(),(eu2 == do2));
            //Console.WriteLine("Euro:  {0}   Peso: {1}   {2}",eu2.GetCantidad(),pe2.GetCantidad(),(eu2 == pe2));
            //Console.WriteLine("dolar: {0}   Peso: {1}   {2}",do2.GetCantidad(),pe2.GetCantidad(),(do2 == pe2));

            Euro eu3 = (Euro)do1;
            Dolar do3 = 100;
            Peso pe3 =(Peso)do1;

            Console.WriteLine("dolar: {0}   Euro:  {1}  {2} ", do3.GetCantidad(),eu3.GetCantidad(), (eu3 == do3));
            Console.WriteLine("Euro:  {0}   Peso:  {1}  {2} ", eu3.GetCantidad(),pe3.GetCantidad(), (eu3 == pe3));
            Console.WriteLine("Peso:  {0}   Dolar: {1}  {2} ", pe3.GetCantidad(),do3.GetCantidad(), (do3 == pe3));

            Dolar do4 = 100;

            eu3 = eu3 + do3;
            do3 = do3 + pe3;
            pe3 = pe3 + do4;

            Console.WriteLine("dolar: {0}   ", do3.GetCantidad());
            Console.WriteLine("Euro:  {0}   ", eu3.GetCantidad());
            Console.WriteLine("Peso:  {0}   ", pe3.GetCantidad());


            Console.ReadKey();






        }
    }
}
