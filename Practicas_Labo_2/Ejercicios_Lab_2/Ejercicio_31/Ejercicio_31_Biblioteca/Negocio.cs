using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_31_Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre) : this()
        {
            this.nombre=nombre;
        }

        public Cliente PropiedadCliente
        {
            get
            {
                 {
                    if (!(this.clientes.Count <= 0))
                    {
                        return this.clientes.Dequeue(); 
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            set
            {
                if (!(this==value))
                {
                    bool respuesta = this+value;
                }
            }
        }

        #region Operadores

        public static bool operator ==(Negocio n,Cliente c)
        {
            //if (n.clientes.Count > 0)
            //{
                foreach (Cliente cli in n.clientes)
                {
                    if (cli == c)
                    {
                        return true;
                    }
                } 
            //}
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.AtenderCliente(n.PropiedadCliente); 
        }
        public static bool operator +(Negocio n,Cliente c)
        {
            n.clientes.Enqueue(c);
            if (n == c)
                return true;
            else
                return false;
        }
        #endregion
    }
}
