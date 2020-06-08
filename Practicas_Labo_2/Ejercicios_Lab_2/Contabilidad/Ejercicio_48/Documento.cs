using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public abstract class Documento
    {
        protected int numero;

        public Documento(int numero)
        {
            this.numero = numero;
        }
        public abstract int Numero { get; }



    }
}
