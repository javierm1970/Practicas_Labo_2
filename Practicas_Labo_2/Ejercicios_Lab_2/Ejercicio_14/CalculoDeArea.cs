using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        public static float CalcularCuadrado(double lado)
        {
            return (float) Math.Pow(lado,2);
        }

        public static float CalcularTriangulo(double baseTriangulo, double altura)
        {
            return (float) (baseTriangulo * altura)/2;
        }

        public static float CalcularCirculo(double radio)
        {
            return (float) (radio * radio * 3.1415);
        }
    }
}
