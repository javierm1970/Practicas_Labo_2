using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_48;

namespace Test_Contabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contab = new Contabilidad<Factura, Recibo>();

            Factura f1 = new Factura(1);
            Factura f2 = new Factura(2);
            Factura f3 = new Factura(3);
            Factura f4 = new Factura(4);
            Factura f5 = new Factura(5);

            Recibo r0 = new Recibo();
            Recibo r1 = new Recibo(1);
            Recibo r2 = new Recibo(2);
            Recibo r3 = new Recibo(3);
            Recibo r4 = new Recibo(4);

            contab += f1;
            contab += f2;
            contab += f3;
            contab += f4;
            contab += f5;

            contab += r0;
            contab += r1;
            contab += r2;
            contab += r3;
            contab += r4;

            foreach (Documento item in contab.Egresos)
            {
                Console.WriteLine(item.Numero);
            }
            foreach (Documento item in contab.Ingresos)
            {
                Console.WriteLine(item.Numero);
            }
            Console.ReadKey();
        }
    }
}
