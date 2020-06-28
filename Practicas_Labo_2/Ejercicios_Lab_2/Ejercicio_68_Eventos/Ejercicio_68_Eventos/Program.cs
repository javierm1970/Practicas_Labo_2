using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ejercicio_68_Eventos_Biblioteca;

namespace Ejercicio_68_Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> clie;
            Caja c1 = new Caja();
            Caja c2 = new Caja();

            Negocio n1 = new Negocio(c1, c2);
           
            n1.Clientes.Add("Javier");
            n1.Clientes.Add("Alejandro");
            n1.Clientes.Add("Juan");
            n1.Clientes.Add("Jorge");
            n1.Clientes.Add("Jorgelina");
            n1.Clientes.Add("Juana");
            n1.Clientes.Add("Marcela");
            n1.Clientes.Add("Ana");
            n1.Clientes.Add("Andrea");
            n1.Clientes.Add("Gina");

            Thread hiloAsignarCaja = new Thread(n1.AsignarCaja);
            Thread hiloAtenderCaja1 = new Thread(c1.AtenderClientes);
            Thread hiloAtenderCaja2 = new Thread(c2.AtenderClientes);
            hiloAtenderCaja1.Name = "Caja 1";
            hiloAtenderCaja2.Name = "Caja 2";


            hiloAsignarCaja.Start();
            hiloAsignarCaja.Join();
            hiloAtenderCaja1.Start();
            hiloAtenderCaja2.Start();

            //Console.WriteLine("Termine");
            //Console.ReadKey();
        }
    }
}
