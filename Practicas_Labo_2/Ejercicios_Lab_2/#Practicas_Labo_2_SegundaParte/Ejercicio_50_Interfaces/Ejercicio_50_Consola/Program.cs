using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_50_Interfaces;

namespace Ejercicio_50_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            IGuardar<string, string> guarda = new GuardarTexto<string, string>();
            IGuardar<string, string> serial = new Serializar<string, string>();
            
            //IGuardar<string, string> serial2 = new IGuardar<string, string>();




            Console.WriteLine(guarda.Leer());
            Console.WriteLine(serial.Leer());
            Console.ReadKey();


        }
    }
}
