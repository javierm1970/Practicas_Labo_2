using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30_Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> autosformula1;

        private Competencia()
        {
            this.autosformula1 = new List<AutoF1>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas) :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('*', 80);
            sb.Append("\nCantidad de Competidores:"+this.cantidadCompetidores);
            sb.Append("\nCantidad de Vueltas: " + this.cantidadVueltas);
            sb.Append("\n");
            sb.Append('*', 80);
            sb.Append("\n");
            
            foreach (AutoF1 item in this.autosformula1)
            {
                sb.AppendFormat(item.MostrarDatos());
            }

            return sb.ToString();
        }

        #region Operadores 

        public static bool operator +(Competencia c,AutoF1 a)
        {
            bool sePudoAgregar = false;
            if (c.autosformula1.Count < c.cantidadCompetidores)
            {   
                if (!(c == a)) 
                {
                    c.autosformula1.Add(a);
                    a.SetEnCompet(true);
                    a.SetVueltasResta(c.cantidadVueltas);
                    sePudoAgregar = true;

                }
            }
            return sePudoAgregar;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool sePudoBorrar = false;
            if (c.autosformula1.Count < c.cantidadCompetidores)
            {
                if (c == a)
                {
                    c.autosformula1.Remove(a);
                    sePudoBorrar = true;
                }
            }
            return sePudoBorrar;
        }

        public static bool operator ==(Competencia c,AutoF1 a)
        {
            bool estaEnCompetencia = false;
            foreach (AutoF1 item in c.autosformula1)
            {
                if (item == a)
                {
                    estaEnCompetencia=true;
                    break;
                }
            }
            if (estaEnCompetencia)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Competencia c,AutoF1 a)
        {
            return !(c == a);
        }

        #endregion

    }
}
