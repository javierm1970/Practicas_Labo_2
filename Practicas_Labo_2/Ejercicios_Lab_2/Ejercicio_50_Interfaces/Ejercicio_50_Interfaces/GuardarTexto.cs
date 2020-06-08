using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50_Interfaces
{
    public class GuardarTexto <T,V> : IGuardar <T,V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }
        public V Leer()
        {
            string mensaje = "Texto Leído";

            V res = (V)Convert.ChangeType(mensaje, typeof(V));
            return res;
        }
    }
}
