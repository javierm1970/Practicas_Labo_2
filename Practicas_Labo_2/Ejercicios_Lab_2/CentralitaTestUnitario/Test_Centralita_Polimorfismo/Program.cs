using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaPolimorfismo;

namespace Test_Centralita_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mi central 
            Centralita c = new Centralita("Fede Center");

            bool compara = false;

            Llamada l1 = new Local("Varela", 20.5f, "Pehuajo", 20.5f);
            Llamada l2 = new Local("Varela", 20.5f, "Pehuajo", 20.5f);

            Llamada l3 = new Provincial("Varela", Provincial.Franja.Franja_1, 30, "Pehuajo");
            Llamada l4 = new Provincial("Varela", Provincial.Franja.Franja_1, 30, "Pehuajo");

            // act
            if ((l1 == l2 && l1 != l3 && l1 != l4) &&
                (l2 != l3 && l2 != l4) &&
                (l3 == l4))
            {
                compara = true;
            }


            ////Mis 4 llamadas 
            //Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);

            //Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            //Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            //Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            //// Las llamadas se irán registrando en la Centralita. 
            //// La centralita mostrará por pantalla todas las llamadas según las vaya registrando. 

            ////c.Llamadas.Add(l1);
            //c = (c + l1);
            ////Console.WriteLine(c.ToString());
            ////Console.ReadKey();
            ////c.Llamadas.Add(l2);
            //c = (c + l2);
            ////Console.WriteLine(c.ToString());
            ////Console.ReadKey();
            ////c.Llamadas.Add(l3);
            //c = (c + l3);
            ////Console.WriteLine(c.ToString());
            ////Console.ReadKey();
            ////c.Llamadas.Add(l4);
            //c = (c + l4);
            ////Console.WriteLine(c.ToString());
            ////Console.ReadKey();


            //c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
            Console.ReadKey();

        }
    }
}
