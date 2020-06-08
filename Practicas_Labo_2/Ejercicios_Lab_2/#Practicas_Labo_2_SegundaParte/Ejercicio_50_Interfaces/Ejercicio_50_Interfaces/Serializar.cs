using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50_Interfaces
{
    public class Serializar <T,S> : IGuardar <T,S>
    {
        public bool Guardar(T obj)
        {
            return true;
        }
        public S Leer()
        {
            string mensaje = "Objeto Leído";
            S res = (S)Convert.ChangeType(mensaje, typeof(S));
            return res;
        }
    }
}
