using Ejercicio_36_Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36_Biblioteca
{
    public class AutoF1 : VehiculoDeCarrera
    {

        static Random rnd;
        private short caballosDeFuerza;

        private AutoF1(short numero, string escuderia)
            :base(numero, escuderia)
        {
        }
        public AutoF1(short numero,string escuderia,short caballosDeFuerza) 
            : this(numero,escuderia)
        {
            this.caballosDeFuerza=caballosDeFuerza;
        }
        public short SetCaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append('*', 80);
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(string.Format("Cantidad de Caballos de fuerza: {0}", this.SetCaballosDeFuerza));
            sb.Append("\n");
            sb.Append('*', 80);
            sb.Append("\n");

            return sb.ToString();
        }
        #region Operadores    
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1 == a2 && a1.caballosDeFuerza==a2.caballosDeFuerza)
                return true;
            else
                return false;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
