using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre)
        {
            this.nombre = nombre;
            this.fechaCreacion = DateTime.Now;
        }

        public string Nombre 
        {
            get 
            {
                return this.nombre; 
            } 
        }
        public DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
        }
        public string Ficha()
        {
            return string.Format("{0} creado en {1}", this.nombre, this.fechaCreacion);
        }
    }
}
