using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_64_Hilos_Biblioteca
{
    public class Caja
    {
        List<string> filaClientes;
        public Caja()
        {
            this.filaClientes = new List<string>();
        }
        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }
        public void AtenderClientes()
        {
            if (!(this.FilaClientes is null))
            {
                foreach (string item in this.filaClientes)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("{0} {1}",item.ToString(),Thread.CurrentThread.Name);
                }
            }
        }
    }
}
