using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Contabilidad <T,U> where U : new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();

        }
        public List<T> Egresos 
        {
            get
            {
                return this.egresos ;
            } 
        }
        public List<U> Ingresos
        {
            get
            {
                return this.ingresos;
            }
        }
        public static Contabilidad <T,U> operator +(Contabilidad<T,U> c, T egresos)
        {
            c.egresos.Add(egresos);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingresos)
        {
            c.ingresos.Add(ingresos);
            return c;
        }


    }
}
