using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31_Bis_Biblioteca
{
    public class Negocio
    {
        
        public Queue<Cliente> clientes;
        public PuestoAtencion caja;
        public string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre): this()
        {
            this.nombre = nombre;
        }
        public Cliente Cliente
        {
            get
            {
                if (!(this.clientes.Count <= 0))
                {
                    return this.clientes.Dequeue();
                }
                return null;
            }
            set
            {
                if (!(this == value))
                {
                    bool respuesta = (this + value);
                }
            }
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cli in n.clientes)
            {
                if (cli == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            n.clientes.Enqueue(c);
            return true;
        }
        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
    }
}
