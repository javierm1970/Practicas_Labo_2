using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_68_Eventos_Biblioteca
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string nombre;
        private string apellido;

        public event DelegadoString eventoString;

        public Persona()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
        }
        public string Nombre 
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!(value == this.nombre))
                {
                    this.nombre = value;
                    string msg = string.Format("{0} \n\n\n{1} ", "Nombre Modificado", this.Mostrar());
                    eventoString.Invoke(msg);
                }
            }
        }
        public string Apellido 
        {
            get
            {
                return this.apellido;
            } 
            set 
            {
                if (!(value == this.apellido))
                {
                    this.apellido = value;
                    string msg = string.Format("{0} \n\n\n{1} ", "Apellido Modificado", this.Mostrar());
                    eventoString.Invoke(msg);
                }
            } 
        }

        public string Mostrar()
        {
            return string.Format("Apellido: {0} \nNombre: {1}", this.Apellido, this.Nombre);
        }


    }
}
