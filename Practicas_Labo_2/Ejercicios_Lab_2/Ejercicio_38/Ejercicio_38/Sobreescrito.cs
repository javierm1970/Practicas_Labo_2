using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    public abstract class Sobreescrito 
    {
        protected string miAtributo;
        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        public abstract string MiPropiedad { get; }
        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi Método ToString sobreescrito!";
        }
        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType())
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
