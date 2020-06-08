using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_29;

namespace Ejercicio_29_Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Equipo equipo1 = new Equipo(30, "Independiente");
            Equipo equipo2 = new Equipo(30, "Racing");

            Jugador jI1 = new Jugador(1, "Campaña");
            Jugador jI2 = new Jugador(2, "Bustos", 3, 22);

            Jugador jR1 = new Jugador(1, "Arias");
            Jugador jR2 = new Jugador(5, "Pillud", 1, 75);

            if (equipo1 + jI1)
            {
                Console.WriteLine("incorporado: \n{0} ", jI1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No fue posible la incorporacion de: \n{0}", jI1.MostrarDatos());
            }

            if (equipo1 + jI2)
            {
                Console.WriteLine("incorporado: \n{0} ", jI2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No fue posible la incorporacion de: \n{0}", jI2.MostrarDatos());
            }




            if (equipo2 + jR1)
            {
                Console.WriteLine("incorporado: \n{0} ", jR1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No fue posible la incorporacion de: \n{0}", jR1.MostrarDatos());
            }
            
            if (equipo2 + jR2)
            {
                Console.WriteLine("incorporado: \n{0} ", jR2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No fue posible la incorporacion de: \n{0}", jR2.MostrarDatos());
            }

            Console.ReadKey();

        }
    }
}
