using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_47;

namespace Test_Torneo
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<Equipo> torneooFutbolApertura = new Torneo<Equipo>();
            Torneo<Equipo> torneoBasquetbolApertura = new Torneo<Equipo>();

            Equipo eq1 = new EquipoFutbol("Independiente",7);
            Equipo eq2 = new EquipoFutbol("Boca",6);
            Equipo eq3 = new EquipoFutbol("River",4);

            bool pudo = (torneooFutbolApertura + eq1);
            pudo = (torneooFutbolApertura + eq2);
            pudo = (torneooFutbolApertura + eq3);

            eq1 = new EquipoBasquetbol("Independiente Basquet",14);
            eq2 = new EquipoBasquetbol("Boca Basquet",26);
            eq3 = new EquipoBasquetbol("River Basquet",18);

            pudo = (torneoBasquetbolApertura + eq1);
            pudo = (torneoBasquetbolApertura + eq2);
            pudo = (torneoBasquetbolApertura + eq3);

            Console.WriteLine(torneooFutbolApertura.Mostrar());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(torneooFutbolApertura.JugarPartido); 
            }

            Console.WriteLine(torneoBasquetbolApertura.Mostrar());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(torneoBasquetbolApertura.JugarPartido);
            }
            Console.ReadKey();
        }
    }
}
