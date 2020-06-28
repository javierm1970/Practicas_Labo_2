using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_72
{
    public static class DigitosLong
    {
        public static string CantidadDigitosLong(this long cantidad)
        {
            return string.Format("{0} dígitos", cantidad.ToString().Length);
        }
    }
}
