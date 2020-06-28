using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_61_Bibliotecas
{
    public class Persona
    {
        private int dni;
        private string nombre;
        private string apellido;

        public Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(string nombre, string apellido)
            :this(0,nombre, apellido)
        {
        }


    }
}
