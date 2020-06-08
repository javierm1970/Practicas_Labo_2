using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31_Biblioteca
{       

    public class PuestoAtencion
    {
        public enum Puesto 
        {
            Caja1, Caja2
        }
        
        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }

        public static int PropiedadNumeroActual
        {
            get
            {
                return ++PuestoAtencion.numeroActual;
            }
        }
        public static int PropiedadClientesPendientes
        {
            get
            {
                return PuestoAtencion.numeroActual;
            }

        }
        public bool AtenderCliente(Cliente c)
        {
            if (!(c is null))
            {
                System.Threading.Thread.Sleep(500);
                return true;
            }
            else
                return false;
        }
    }
}
