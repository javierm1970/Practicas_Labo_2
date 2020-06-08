using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Ejercicio_42
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                LanzarException();
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }
        public MiClase(int numero)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("Esta es mi Exception: UnaExcepcion 2do Constructor",e);
            }
        }
        public static void LanzarException()
        {
            try
            {
                int aux = 0;
                int res = 2 / aux;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }
    }
}
