using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_73
{
    public static class CuentaChar
    {
        public static string CuentaSignosPuntuacion(this string auxChar)
        {
            int punto = 0;
            int coma = 0;
            int puntoYComa = 0;

            for (int i = 0; i < auxChar.Length; i++)
            {
                switch (auxChar[i])
                {
                    case '.':
                        punto++;
                        break;
                    case ',':
                        coma++;
                        break;
                    case ';':
                        puntoYComa++;
                        break;
                    default:
                        break;
                }
            }
            return string.Format("Puntos: {0}  /  Comas: {1}  /  Puntos y Comas: {2}",
                punto, coma, puntoYComa);
        }
    }
}
