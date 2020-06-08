using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36_Herencia
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        private Random rnd;

        public VehiculoDeCarrera()
        {
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;

        }
        public VehiculoDeCarrera(short numero, string escuderia):this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
            rnd = new Random();
        }
        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }
        public bool EnCompetencia
        {
            set
            {
                this.enCompetencia = value;
            }
            get
            {
                return this.enCompetencia;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        public short CantidadCombustible
        {
            get
            {
                rnd = new Random();
                return this.cantidadCombustible = (short)rnd.Next(15, 100);
            }
            set
            {
                this.cantidadCombustible=value;
            }
        }
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append('*', 80);
            sb.Append("\nEscuderia: " + this.escuderia);
            sb.Append("\nNumero: " + this.numero);
            sb.AppendFormat("\nEsta en Competencia? {0}    Cantidad de Vueltas: {1}  Combustible Restante: {2}",
                this.enCompetencia, this.vueltasRestantes, this.cantidadCombustible);
            sb.Append("\n");
            sb.Append('*', 80);
            sb.Append("\n");

            return sb.ToString();
        }
        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            if (a1.Numero == a2.Numero &&
                a1.Escuderia == a2.Escuderia)
                return true;
            else
                return false;
        }
        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }

    }

}
