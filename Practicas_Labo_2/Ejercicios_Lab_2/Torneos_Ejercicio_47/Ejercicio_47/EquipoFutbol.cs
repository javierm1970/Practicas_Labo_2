using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class EquipoFutbol : Equipo
    {
        private int cantidadDeCopasLibertadores;

        public EquipoFutbol(string nombre, int cantidadDeCopasLibertadores)
            :base(nombre)
        {
            this.cantidadDeCopasLibertadores = cantidadDeCopasLibertadores;
        }

    }
}
