using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30_Biblioteca
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        static Random rnd;

        private AutoF1()
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
        }
        public AutoF1(short numero,string escuderia) : this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        private short SetCantidadCombustible
        {
            set
            {
                this.cantidadCombustible = value;
            }
            get
            {
                return this.cantidadCombustible;
            }
        }

        private bool SetEnCompetencia
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
        
        private short SetVueltasRestantes
        {
            set
            {
                this.vueltasRestantes = value;
            }
            get
            {
                return this.vueltasRestantes;
            }
        }

        public short GetCantidadCombustible()
        {
            return this.SetCantidadCombustible;
        }
        public void SetCantidadCombusible(short cantCombu)
        {
            SetCantidadCombustible = cantCombu;
        }

        public bool GetEnCompetencia()
        {
            return this.SetEnCompetencia;
        }
        public void SetEnCompet(bool enCompete)
        {
            rnd = new Random();
            this.cantidadCombustible = (short)rnd.Next(15, 100);
            SetEnCompetencia = enCompete;
        }

        public short GetVueltasResta()
        {
            return this.vueltasRestantes;
        }
        public void SetVueltasResta(short cantVueltas)
        {
            SetVueltasRestantes = cantVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append('*', 80);
            sb.Append("\nEscuderia: " + this.escuderia);
            sb.Append("\nNumero: " + this.numero);
            sb.AppendFormat("\nEsta en Competencia? {0}    Cantidad de Vueltas: {1}  Combustible Restante: {2}",
                this.enCompetencia,this.vueltasRestantes,this.cantidadCombustible);
            sb.Append("\n");
            sb.Append('*', 80);
            sb.Append("\n");

            return sb.ToString();
        }

        #region Operadores    
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
