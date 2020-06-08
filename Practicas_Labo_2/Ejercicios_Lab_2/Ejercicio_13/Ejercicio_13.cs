using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Ejercicio_13
    {
        static void Main(string[] args)
        {
            Console.Title = string.Format("Ejercicio Nº {0:##}", 13);

            int paso_Int=72;
            string recibo_String;

            string paso_String="11111";
            int recibo_Int;


            recibo_String = Conversor.DecimalBinario(paso_Int);

            Console.WriteLine("converti {0}    en     {1}", paso_Int, recibo_String);
            
            recibo_Int = Conversor.BinarioDecimal(paso_String);

            Console.WriteLine("converti {0}    en     {1}", paso_String, recibo_Int);

            Console.ReadKey();

        }
    }
}
