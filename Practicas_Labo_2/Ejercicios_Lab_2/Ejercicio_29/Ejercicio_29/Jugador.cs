using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            //this.promedioGoles = 0;
        }
        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre,int cantidadGoles, int cantidadPartidos) : this(dni,nombre)
        {
            this.partidosJugados = cantidadPartidos;
            this.totalGoles = cantidadGoles;
            //this.promedioGoles = (float)cantidadGoles / cantidadPartidos;
        }
        
        public int PropiedadCantidadPartidos
        {
            get
            {
                return this.PropiedadCantidadPartidos;
            }
        }
        public float PropiedadPromedioDeGoles
        {
            get
            {
                return this.totalGoles/this.partidosJugados;
            }
        }
        public int PropiedadCantidadGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        public int PropiedadDni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public string PropiedadNombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        
        
        public float GetPromedioGoles()
        {
            return this.promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append('-', 80);
            sb.Append("\nDni: " + this.dni);
            sb.Append("\nNombre: " + this.nombre);
            sb.AppendFormat("\nPartidos Jugados: {0}    Promerio de Goles: {1} \n", this.partidosJugados, this.promedioGoles);
            sb.Append('-', 80);
            sb.Append("\n");
            return sb.ToString();
        }

        #region Operador
        public static bool operator == (Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator != (Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}
