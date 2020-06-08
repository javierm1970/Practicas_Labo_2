using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Ejercicio_42
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje, Exception inner)
            : base(mensaje, inner)
        { }
        public MiExcepcion(string mensaje)
            : base(mensaje)
        { }

        public override string ToString()
        {
            return string.Format("{0}  Origen del error: {1}",base.Message,base.Source);

        }
    }
}
