using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0)
        {

        }
        public long Sumar(long i, long j)
        {
            this.cantidadSumas++;
            return i + j;
        }
        public string Sumar (string a, string b)
        {
            this.cantidadSumas++;
            return a + " " + b;
        }
        
        public static long operator + (Sumador a, Sumador b)
        {
            return a.cantidadSumas + b.cantidadSumas;
        }

        public static bool operator | (Sumador a, Sumador b)
        {
            if (a.cantidadSumas == b.cantidadSumas)
            {
                return true;
            }
            return false;
        }

        public static explicit operator int(Sumador a)
        {
            return a.cantidadSumas;
        }

    }
}
