using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_31_Bis_Biblioteca;

namespace Ejercicio_31_Bis_Biblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<Cliente> prueba = new Queue<Cliente>();


            
            
            Cliente c1 = new Cliente(1, "Cliente1");
            Cliente c2 = new Cliente(2, "Cliente2");
            Cliente c3 = new Cliente(3, "Cliente3");
            Cliente c4 = new Cliente(4, "Cliente4");
            Cliente c5 = new Cliente(5, "Cliente5");
            
            Cliente c6 = new Cliente(1, "Cliente5");
            Cliente c7 = new Cliente(2, "Cliente5");
            Cliente c8 = new Cliente(3, "Cliente5");

            prueba.Enqueue(c1);
            prueba.Enqueue(c2);
            prueba.Enqueue(c3);
            prueba.Enqueue(c4);
            prueba.Enqueue(c5);
            //prueba.Enqueue(c6);
            //prueba.Enqueue(c7);
            //prueba.Enqueue(c8);


            Negocio n1 = new Negocio("P");

            Console.WriteLine("{0}",(n1.Cliente=c1).nombre);
            Console.WriteLine("{0}",(n1.Cliente=c2).nombre);
            Console.WriteLine("{0}",(n1.Cliente=c3).nombre);
            Console.WriteLine("{0}",(n1.Cliente=c4).nombre);
            Console.WriteLine("{0}",(n1.Cliente=c5).nombre);
            
            Console.ReadKey();

            while (~n1)
            {
                Console.WriteLine("Cliente fue atendido");
            }

            Console.ReadKey();


        }
    }
}
