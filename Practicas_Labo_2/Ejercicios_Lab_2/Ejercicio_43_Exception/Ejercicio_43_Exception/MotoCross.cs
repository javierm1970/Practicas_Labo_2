using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43_Exeption
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        private MotoCross(short numero, string escuderia)
    :       base(numero, escuderia)
        {
        }
        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append('*', 80);
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(string.Format("Cantidad Cilindradas: {0}", this.Cilindrada));
            sb.Append("\n");
            sb.Append('*', 80);
            sb.Append("\n");

            return sb.ToString();
        }
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if (a1 == a2 && a1.Cilindrada == a2.Cilindrada)
                return true;
            else
                return false;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }


    }
}
