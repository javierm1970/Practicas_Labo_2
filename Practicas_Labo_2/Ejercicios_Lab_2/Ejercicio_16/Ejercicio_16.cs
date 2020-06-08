using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Ejercicio_16
    {
        static void Main(string[] args)
        {
            byte notaAlum1;
            byte notaAlum2;

            Console.Title = string.Format("Ejercicio Nº {0:##}", 16);

            Alumno alum1 = new Alumno();
            Alumno alum2 = new Alumno();
            Alumno alum3 = new Alumno();

            alum1.apellido = "Magdaleno";
            alum1.nombre = "Javier";
            alum1.legajo = 1;
            notaAlum1 = 6;
            notaAlum2 = 5;

            alum1.Estudiar(notaAlum1, notaAlum2);

            alum1.Mostrar();

            
            alum2.apellido = "Lozano";
            alum2.nombre = "Ana";
            alum2.legajo = 1;
            notaAlum1 = 9;
            notaAlum2 = 8;

            alum2.Estudiar(notaAlum1, notaAlum2);

            alum2.Mostrar();


            alum3.apellido = "Magda";
            alum3.nombre = "Iker";
            alum3.legajo = 1;
            notaAlum1 = 4;
            notaAlum2 = 6;

            alum3.Estudiar(notaAlum1, notaAlum2);

            alum3.Mostrar();

            Console.ReadKey();

        }
    }
}
