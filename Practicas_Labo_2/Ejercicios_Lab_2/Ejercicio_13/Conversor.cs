using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {
        public static string DecimalBinario(int num_Entero)
        {
            string num_String;
            int resto = num_Entero;
            string auxString = "";

            while (resto / 2 >= 1)
            {
                if (resto % 2 == 0)
                {
                    auxString = "0" + auxString;
                }
                else
                {
                    auxString = "1" + auxString;
                }
                resto = resto / 2;
            }
            num_String = "1" + auxString;
            //num_String = Convert.ToString(num_Entero, 2);
            return num_String;
        }

        public static int BinarioDecimal(string num_Binario)
        {
            int num_Entero2=0;
            int i=(num_Binario.Length-1);

            foreach (char numero in num_Binario)
            {
                if (numero == '1')
                {
                    num_Entero2 = num_Entero2 +(int) Math.Pow(2,i);
                }
                i--;
            }
            return num_Entero2;
        }
    }
}
