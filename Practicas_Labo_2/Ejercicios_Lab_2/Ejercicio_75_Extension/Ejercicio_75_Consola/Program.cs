using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_75;

namespace Ejercicio_75_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string diasFaltantes;
            DateTime cuantofaltapara = DateTime.Now;

            diasFaltantes = cuantofaltapara.ObtenerPlacaCronica(EstacionesAnuales.Estaciones.Invierno);

            Console.WriteLine(diasFaltantes);


            diasFaltantes = cuantofaltapara.ObtenerPlacaCronica(EstacionesAnuales.Estaciones.Otoño);
            Console.WriteLine(diasFaltantes);


            diasFaltantes = cuantofaltapara.ObtenerPlacaCronica(EstacionesAnuales.Estaciones.Primavera);
            Console.WriteLine(diasFaltantes);


            diasFaltantes = cuantofaltapara.ObtenerPlacaCronica(EstacionesAnuales.Estaciones.Verano);
            Console.WriteLine(diasFaltantes);
            Console.ReadKey();
        }
    }
}
