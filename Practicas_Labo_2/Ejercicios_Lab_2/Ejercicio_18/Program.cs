using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = string.Format("Ejercicio Nº {0:##}", 18);


            float areaRec;
            float perimetroRec;

            Punto p1 = new Punto(1, 3);
            Punto p3 = new Punto(9, 8);
            
            
            Console.WriteLine("Punto 1: {0},{1}", p1.GetX().ToString(), p1.GetY().ToString());
            Console.WriteLine("Punto 3: {0},{1}", p3.GetX().ToString(), p3.GetY().ToString());
            
            Rectangulo r1 = new Rectangulo(p1,p3);

            
            areaRec = r1.Area();
            perimetroRec = r1.Perimetro();

            Console.WriteLine("el Area de R1 = {0}  y  el Perimetro = {1}", areaRec, perimetroRec);
            Console.ReadKey();
        }
    }
}
