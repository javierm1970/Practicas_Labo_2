using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_15;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static string Calcular(int operando1, int operando2, char tipo_Calculo)
        {
            switch (tipo_Calculo)
            {
                case '+':
                    return ((float)operando1 + (float)operando2).ToString();

                case '-':
                    return ((float)operando1 - (float)operando2).ToString();

                case '*':
                    return ((float)operando1 * (float)operando2).ToString();

                case '/':
                    if (Validar(operando2))
                    {
                        return ((float)operando1 / (float)operando2).ToString();
                    }

                    return "Error. El 2do Operando debe ser distinto de 0. Reingrese";

                default:
                    return "Error. Signo invalido";
            }
        }

        private static bool Validar(int operando2_Val)
        {
            if (!(operando2_Val == 0))
            {
                return true;
            }
            return false;
        }
    }
}
