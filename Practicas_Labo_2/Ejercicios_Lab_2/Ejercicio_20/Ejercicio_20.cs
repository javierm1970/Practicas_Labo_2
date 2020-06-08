using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;


namespace Ejercicio_20
{
    class Ejercicio_20
    {
        static void Main(string[] args)
        {
            Console.Title = string.Format("Ejercicio Nº {0:##}", 21);

            Dolar do1 = new Dolar(100);
            Dolar do2;
            Dolar do3;
            Euro eu1 = new Euro(100/1.16);
            Peso pe1 = new Peso(3833);

            do2 = (Dolar)eu1;
            do3 = (Dolar)pe1;
            Dolar do4 = (Dolar)pe1;


            Console.WriteLine("{0}   {1}    {2}     ", do2.GetCantidad(), do3.GetCantidad(),do4.GetCantidad());
            Console.ReadKey();



            Console.WriteLine("Cotizacion del Dolar {0}:", Dolar.GetCotizacion());
            Console.WriteLine("Cotizacion del Euro  {0}:", Euro.GetCotizacion());
            Console.WriteLine("Cotizacion del Peso  {0}:", Peso.GetCotizacion());
            Console.WriteLine("\n");
            //**********************************************************************
            /*
    
            */
            



            Console.WriteLine("{0,10}     {1,10}       {2,10}", (pe1 == do1),(pe1 == eu1),(do1 == eu1));
            

            Console.WriteLine("{0,10}     {1,10}       {2,10}", (pe1 != do1),(pe1 != eu1),(do1 != eu1));

            Console.Read();
            //**********************************************************************



            Console.WriteLine("Peso  {0,16}  +  Dolares {1,16}   =   Pesos {2,15}", pe1.GetCantidad(), do1.GetCantidad(), ((Peso)(pe1 + do1)).GetCantidad());

            Console.WriteLine("Peso  {0,16}  +  Euros   {1,16}   =   Pesos {2,15}", pe1.GetCantidad(), eu1.GetCantidad(), ((Peso)(pe1 + eu1)).GetCantidad());

            Console.WriteLine("Dolar {0,16}  +  Pesos   {1,16}   =   Dolar {2,15}", do1.GetCantidad(), pe1.GetCantidad(), ((Dolar)(do1 + pe1)).GetCantidad());

            Console.WriteLine("Dolar {0,16}  +  Euros   {1,16}   =   Dolar {2,15}", do1.GetCantidad(), eu1.GetCantidad(), ((Dolar)(do1 + eu1)).GetCantidad());

            Console.WriteLine("Euro  {0,16}  +  Pesos   {1,16}   =   Euros {2,15}", eu1.GetCantidad(), pe1.GetCantidad(), ((Euro)(eu1 + pe1)).GetCantidad());

            Console.WriteLine("Euro  {0,16}  +  Dolares {1,16}   =   Euros {2,15}", eu1.GetCantidad(), do1.GetCantidad(), ((Euro)(eu1 + do1)).GetCantidad());


            Console.WriteLine("====================================");


            //**********************************************************************

            Console.WriteLine("Peso  {0,16}  -  Dolares {1,16}   =   Pesos {2,15}", pe1.GetCantidad(), do1.GetCantidad(), ((Peso)(pe1 - do1)).GetCantidad());

            Console.WriteLine("Peso  {0,16}  -  Euros   {1,16}   =   Pesos {2,15}", pe1.GetCantidad(), eu1.GetCantidad(), ((Peso)(pe1 - eu1)).GetCantidad());

            Console.WriteLine("Dolar {0,16}  -  Pesos   {1,16}   =   Dolar {2,15}", do1.GetCantidad(), pe1.GetCantidad(), ((Dolar)(do1 - pe1)).GetCantidad());

            Console.WriteLine("Dolar {0,16}  -  Euros   {1,16}   =   Dolar {2,15}", do1.GetCantidad(), eu1.GetCantidad(), ((Dolar)(do1 - eu1)).GetCantidad());

            Console.WriteLine("Euro  {0,16}  -  Pesos   {1,16}   =   Euros {2,15}", eu1.GetCantidad(), pe1.GetCantidad(), ((Euro)(eu1 - pe1)).GetCantidad());

            Console.WriteLine("Euro  {0,16}  -  Dolares {1,16}   =   Euros {2,15}", eu1.GetCantidad(), do1.GetCantidad(), ((Euro)(eu1 - do1)).GetCantidad());



            Console.ReadKey();


        }
    }
}