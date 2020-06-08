using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = string.Format("Ejercicio Nº {0:##}", 19);


            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador();
            int cuantasSumas = (int) s1;

            Console.WriteLine("Suma dos long: {0}",s1.Sumar(18, 12));

            Console.WriteLine("Concatena dos strings : {0}", s1.Sumar("Javier","Magdaleno"));

            cuantasSumas = (int) s1;
            Console.WriteLine(cuantasSumas);

            Console.WriteLine("Suma dos long: {0}", s1.Sumar(26, 24));
            
            Console.WriteLine("Concatena dos strings : {0}", s1.Sumar("Javier1", "Magdaleno1"));

            cuantasSumas = (int) s1;
            Console.WriteLine(cuantasSumas);
            
            Console.WriteLine("Suma dos long: {0}", s1.Sumar(35, 25));
            
            Console.WriteLine("Concatena dos strings : {0}", s1.Sumar("Javier2", "Magdaleno2"));


            Console.WriteLine("Suma dos long: {0}", s2.Sumar(45, 25));


            Console.WriteLine("Suma CantidadSumas de dos Objetos Sumador: {0}", s1 + s2);

            Console.WriteLine("Las CantidadSumas de estos dos Objetos, son Iguales? {0}", s1 | s2);
            
            s2 = new Sumador(6);

            Console.WriteLine("Y ahora, son Iguales? {0}", s1 | s2);


            Console.ReadKey();
        }
    }
}
