using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_62;

namespace Ejercicio_62_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProvincialDAO l1P = new ProvincialDAO(7, 40, "42554131", "#221867035", 20f);
            //l1P.Guardar();

            //ProvincialDAO l2P = new ProvincialDAO(8, 40, "42554131", "#221867036", 20f);
            //l2P.Guardar();

            //ProvincialDAO l3P = new ProvincialDAO(9, 40, "42554131", "#221867037", 20f);
            //l3P.Guardar();

            //ProvincialDAO l4P = new ProvincialDAO(10, 40, "42554131", "#221867038", 20f);
            //l4P.Guardar();

            LocalDAO l35P = new LocalDAO(35, 40, "42554131", "867035", 20.5f);
            l35P.Guardar();

            LocalDAO l36P = new LocalDAO(36, 40, "42554131", "867036", 20.5f);
            l36P.Guardar();

            LocalDAO l37P = new LocalDAO(37, 40, "42554131", "1867037", 20.5f);
            l37P.Guardar();

            LocalDAO l38P = new LocalDAO(38, 40, "42554131", "867038", 20.5f);
            l38P.Guardar();


            LocalDAO auxLlamada = new LocalDAO();
            
            auxLlamada = auxLlamada.Leer("37");

            Console.WriteLine(auxLlamada.ToString());
            Console.ReadKey();


        }
    }
}
