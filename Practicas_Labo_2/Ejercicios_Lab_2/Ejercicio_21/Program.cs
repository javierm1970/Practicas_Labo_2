using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_21_Biblioteca;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = string.Format("Ejercicio Nº {0:##}", 21);

            Dolar do1 = new Dolar(5);
            Dolar do2 = new Dolar(5);
            
            Euro eu1 = new Euro(5);
            Euro eu2 = new Euro(5);
            
            Peso pe1 = new Peso(5);
            Peso pe2 = new Peso(5);

            Console.WriteLine("Cotizacion del Dolar {0}:", Dolar.GetCotizacion());
            Console.WriteLine("Cotizacion del Euro  {0}:", Euro.GetCotizacion());
            Console.WriteLine("Cotizacion del Peso  {0}:", Peso.GetCotizacion());
            Console.WriteLine("\n");
            //**********************************************************************
            

            //**********************************************************************

            do1 = (Dolar)pe1;
            Console.WriteLine("{0}     Kelvin :      Farhen:  {1}",pe1.GetCantidad(),do1.GetCantidad());
            eu1 = (Euro)pe2;
            Console.WriteLine("{0}     Kelvin :      Celsius: {1}",pe1.GetCantidad(),eu1.GetCantidad());
            eu1 = new Euro(5);
            do1 = new Dolar(5);
            pe1 = (Peso)eu1;
            Console.WriteLine("{0}     Celsius:      Kelvin:  {1}",eu1.GetCantidad(),pe1.GetCantidad());
            
            do2 = (Dolar)eu2;
            Console.WriteLine("{0}     Celsius:      Farhen:  {1}", eu2.GetCantidad(), do2.GetCantidad());
            do2 = new Dolar(5);
            eu2 = (Euro)do2;
            Console.WriteLine("{0}     Farhen :      Celsius: {1}", do2.GetCantidad(), eu2.GetCantidad());
            do2 = new Dolar(5);
            pe2 = (Peso)do2;
            Console.WriteLine("{0}     Farhen :      Kelvin:  {1}", do2.GetCantidad(), pe2.GetCantidad());



            //**********************************************************************


            //**********************************************************************
            
            pe1 = (Peso)1;
            pe2 = (Peso)5;
            
            Console.WriteLine("{0}       {1}", pe1.GetCantidad(), pe2.GetCantidad());
            //**********************************************************************
            eu1 = (Euro)1;
            eu2 = (Euro)5;
            Console.WriteLine("{0}       {1}", eu1.GetCantidad(), eu2.GetCantidad());
            //**********************************************************************
            do1 = (Dolar)1;
            do2 = (Dolar)5;
            Console.WriteLine("{0}       {1}", do1.GetCantidad(), do2.GetCantidad());
            //**********************************************************************
            
            do1 = new Dolar(5);
            do2 = new Dolar(10);
            Dolar do3 = new Dolar(15);
            eu1 = new Euro(-15);
            eu2 = new Euro(-12.22);
            Euro eu3 = new Euro(-9.44);
            pe1 = new Peso(258.15);
            pe2 = new Peso(260.93);
            Peso pe3 = new Peso(263.7);
            bool pesoBool;
            bool euroBool;
            bool dolarBool;
            bool pesoBool1;
            bool euroBool1;
            bool dolarBool1;

            pesoBool = (pe1 == do1);
            pesoBool1 = (pe2 == eu1);
            Console.WriteLine("{0}   {1}", pesoBool, pesoBool1);


            dolarBool = (do1 == pe1);
            dolarBool1 = (do2 == eu1);
            Console.WriteLine("{0}   {1}", dolarBool, dolarBool1);

            euroBool = (eu1 == pe1);
            euroBool1 = (eu2 == do1);
            Console.WriteLine("{0}   {1}", euroBool, euroBool1);

            //**********************************************************************

            pesoBool = (pe1 != do1);
            pesoBool1 = (pe2 != eu1);
            Console.WriteLine("{0}   {1}", pesoBool, pesoBool1);


            dolarBool = (do1 != pe1);
            dolarBool1 = (do2 != eu1);
            Console.WriteLine("{0}   {1}", dolarBool, dolarBool1);


            euroBool = (eu1 != pe1);
            euroBool1 = (eu2 != do1);
            Console.WriteLine("{0}   {1}", euroBool, euroBool1);
            //**********************************************************************

            do1 = new Dolar(1);
            do2 = new Dolar(1);
            do3 = new Dolar(1);
            eu1 = new Euro(-17.22);
            eu2 = new Euro(-17.22);
            eu3 = new Euro(-17.22);
            pe1 = new Peso(255.93);
            pe2 = new Peso(255.93);
            pe3 = new Peso(255.93);


            pe1 = (pe2 + do1);
            Console.WriteLine("pe2 {0}  +  do1 {1}   =   pe1 {2}", pe2.GetCantidad(), do1.GetCantidad(), pe1.GetCantidad());
            pe2 = (pe3 + eu1);
            Console.WriteLine("pe3 {0}  +  eu1 {1}   =   pe2 {2}", pe3.GetCantidad(), eu1.GetCantidad(), pe2.GetCantidad());
            Console.WriteLine("====================================");

            pe1 = new Peso(255.93);

            do1 = (do2 + pe1);
            Console.WriteLine("do2 {0}  +  pe1 {1}   =   do1   {2}", do2.GetCantidad(), pe1.GetCantidad(), do1.GetCantidad());
            do2 = (do3 + eu1);
            Console.WriteLine("do3 {0}  +  eu1 {1}   =   do2   {2}", do3.GetCantidad(), eu1.GetCantidad(), do2.GetCantidad());
            Console.WriteLine("====================================");


            do1 = new Dolar(1);

            eu1 = (eu2 + pe1);
            Console.WriteLine("eu2 {0}  +  pe1 {1}   =   eu1   {2}", eu2.GetCantidad(), pe1.GetCantidad(), eu1.GetCantidad());
            eu2 = (eu3 + do1);
            Console.WriteLine("eu3 {0}  +  do1 {1}   =   eu2   {2}", eu3.GetCantidad(), do1.GetCantidad(), eu2.GetCantidad());
            Console.WriteLine("====================================");

            //**********************************************************************


            do1 = new Dolar(1);
            do2 = new Dolar(1);
            do3 = new Dolar(1);
            eu1 = new Euro(-17.22);
            eu2 = new Euro(-17.22);
            eu3 = new Euro(-17.22);
            pe1 = new Peso(255.93);
            pe2 = new Peso(255.93);
            pe3 = new Peso(255.93);


            pe1 = pe2 - do1;
            Console.WriteLine("pe2 {0}  -  do1 {1}   =   pe1 {2}", pe2.GetCantidad(), do1.GetCantidad(), pe1.GetCantidad());
            pe2 = pe3 - eu1;
            Console.WriteLine("pe3 {0}  -  eu1 {1}   =   pe2 {2}", pe3.GetCantidad(), eu1.GetCantidad(), pe2.GetCantidad());

            Console.WriteLine("====================================");



            pe1 = new Peso(255.93);

            do1 = (do2 - pe1);
            Console.WriteLine("do2 {0}  -  pe1 {1}   =   do1   {2}", do2.GetCantidad(), pe1.GetCantidad(), do1.GetCantidad());
            do2 = (do3 - eu1);
            Console.WriteLine("do3 {0}  -  eu1 {1}   =   do2   {2}", do3.GetCantidad(), eu1.GetCantidad(), do2.GetCantidad());
            Console.WriteLine("====================================");


            do1 = new Dolar(1);

            eu1 = (eu2 - pe1);
            Console.WriteLine("eu2 {0}  -  pe1 {1}   =   eu1   {2}", eu2.GetCantidad(), pe1.GetCantidad(), eu1.GetCantidad());
            eu2 = (eu3 - do1);
            Console.WriteLine("eu3 {0}  -  do1 {1}   =   eu2   {2}", eu3.GetCantidad(), do1.GetCantidad(), eu2.GetCantidad());
            Console.WriteLine("====================================");


            Console.ReadKey();

        }
    }
}
