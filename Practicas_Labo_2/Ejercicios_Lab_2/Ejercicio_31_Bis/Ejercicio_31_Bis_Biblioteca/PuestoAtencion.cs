using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_31_Bis_Biblioteca
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1, Caja2
        }

        public static int numeroActual;
        public Puesto puesto;

        private PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }
        public static int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        }
        public bool Atender(Cliente cli)
        {
            if (!(cli is null))
            {
                System.Threading.Thread.Sleep(500);
                return true;
            }
            else
                return false;
        }
    }
}
