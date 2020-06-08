using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class EquipoBasquetbol : Equipo
    {
        private int cantidadDeTorneosLocales;
        public EquipoBasquetbol(string nombre, int cantidadTorneosLocales)
            :base(nombre)
        {
            this.cantidadDeTorneosLocales = cantidadTorneosLocales;
        }
    }
}
