using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_64_Hilos_Biblioteca
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Negocio(Caja c1, Caja c2)
        {
            this.caja1 = c1;
            this.caja2 = c2;
            clientes = new List<string>();
        }
        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }
        public Caja Caja2
        {
            get
            {
                return this.Caja2;
            }
        }
        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }
        public void AsignarCaja()
        {

            if (!(this.Clientes is null))
            {
                Console.WriteLine("Asignando cajas...");
                foreach (string item in this.Clientes)
                {
                    if (caja1.FilaClientes.Count <= caja2.FilaClientes.Count)
                    {
                        Thread.Sleep(1000);
                        caja1.FilaClientes.Add(item);
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        caja2.FilaClientes.Add(item);
                    }
                }
            }
        }
    }
}
