using Ejercicio_31_Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = string.Format("Ejercicio Nº {0:##}", 31);
            
            Cliente cl1 = new Cliente(1, "javier");
            Cliente cl2 = new Cliente(2, "Jorge");
            Cliente cl3 = new Cliente(3, "juan");
            Cliente cl4 = new Cliente(4, "juana");
            Cliente cl5 = new Cliente(5, "ana");
            //Cliente cl6 = new Cliente(1, "analia");
            //Cliente cl7 = new Cliente(2, "Marcela");
            //Cliente cl8 = new Cliente(3, "Cristian");
            
            Negocio n1 = new Negocio("P");


            Console.WriteLine("{0} ", (n1.PropiedadCliente = cl1).PropiedadNombre);
            Console.WriteLine("{0} ", (n1.PropiedadCliente = cl2).PropiedadNombre);
            Console.WriteLine("{0} ", (n1.PropiedadCliente = cl3).PropiedadNombre);
            Console.WriteLine("{0} ", (n1.PropiedadCliente = cl4).PropiedadNombre);
            Console.WriteLine("{0} ", (n1.PropiedadCliente = cl5).PropiedadNombre);
            //Console.WriteLine("{0} ", (n1.PropiedadCliente = cl6).PropiedadNombre);
            //Console.WriteLine("{0} ", (n1.PropiedadCliente = cl7).PropiedadNombre);
            //Console.WriteLine("{0} ", (n1.PropiedadCliente = cl8).PropiedadNombre);


            //Console.WriteLine(cl1 == cl6);
            //Console.WriteLine(cl2 == cl7);
            //Console.WriteLine(cl3 == cl8);

            Console.ReadKey();

            while (~n1)
            {
                Console.WriteLine("Se quito de la cola");
            }


            Console.ReadKey();
            
            /*
            n1.clientes.Enqueue(cl1);
            Console.WriteLine(cl1.PropiedadNombre);

            n1.clientes.Enqueue(cl5);
            Console.WriteLine(cl5.PropiedadNombre);
            
            n1.clientes.Enqueue(cl3);
            Console.WriteLine(cl3.PropiedadNombre);

            Console.ReadKey();

            int i = n1.clientes.Count();
            Console.WriteLine(n1.clientes.Dequeue().PropiedadNumero);
            Console.WriteLine(n1.clientes.Dequeue().PropiedadNumero);
            Console.WriteLine(n1.clientes.Dequeue().PropiedadNumero);
            //Console.WriteLine(n1.clientes.Dequeue().PropiedadNumero);
            
            int j = n1.clientes.Count();

            Console.ReadKey();
            

            if (n1 + cl1)
            {
                Console.WriteLine("se agrego el cliente: {0}");
            }
            else
            {
                Console.WriteLine("No se pudo Agregar {0}, ya existia en la cola");
            }
            if (n1 + cl2)
            {
                Console.WriteLine("se agrego el cliente: {0}");
            }
            else
            {
                Console.WriteLine("No se pudo Agregar {0}, ya existia en la cola");
            }
            if (n1 + cl3)
            {
                Console.WriteLine("se agrego el cliente: {0}");
            }
            else
            {
                Console.WriteLine("No se pudo Agregar {0}, ya existia en la cola");
            }
            Console.ReadKey();

            while (~n1)
            {
                Console.WriteLine("Pendientes: {0} ",PuestoAtencion.PropiedadClientesPendientes);

            }
            */

            //Console.ReadKey();
        }
    }
}
