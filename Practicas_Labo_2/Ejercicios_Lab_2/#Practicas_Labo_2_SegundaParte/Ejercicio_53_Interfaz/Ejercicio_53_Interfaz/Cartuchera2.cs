using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53_Interfaz
{
    public class Cartuchera2
    {
        public List<Boligrafo> boligrafos;
        public List<Lapiz> lapices;

        public Cartuchera2()
        {
            boligrafos = new List<Boligrafo>(20);
            lapices = new List<Lapiz>(10);
        }
        public bool ProbarElementos()
        {
            bool pudoGastar = true;
            foreach (Boligrafo item in this.boligrafos)
            {
                if (item.UnidadDeEscritura > 0)
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
            foreach (Lapiz item in this.lapices)
            {
                if (((IAcciones)item).UnidadDeEscritura > 0)
                {
                    ((IAcciones)item).UnidadDeEscritura -= 1;

                    //if (((IAcciones)item).UnidadDeEscritura <= 0)
                    //{
                    //    ((IAcciones)item).Recargar(10);
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
