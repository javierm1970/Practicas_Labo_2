using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53_Interfaz
{
    public class Cartuchera1
    {
        public List<IAcciones> utiles;

        public Cartuchera1()
        {
            utiles = new List<IAcciones>();
        }
        public bool ProbarElementos()
        {
            bool pudoGastar=true;
            foreach (IAcciones item in this.utiles)
            {
                if (item.UnidadDeEscritura>0)
                {
                    item.UnidadDeEscritura -= 1;

                    //if (item.UnidadDeEscritura <= 0)
                    //{
                    //    item.Recargar(20); 
                    //}
                }
                else
                {
                    pudoGastar = false;
                }
            }
            return pudoGastar;
        }
    }
}
