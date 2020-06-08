using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_46_TestUnitarios
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje,string nombreClase,string nombreMetodo)
            :base(mensaje)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }
        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo,Exception innerExecption)
            :base(mensaje,innerExecption)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }
        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            CompetenciaNoDisponibleException ex = this;
            
            sb.AppendLine("\nNo es posible acceder a la Competencia");
            sb.AppendFormat("\n{0,-60} Metodo: {1,-15} de la Clase: {2,-15}",ex.Message,ex.nombreMetodo,ex.nombreClase);
            
            //sb.AppendFormat("\nExcepción en el metodo: {0} de la Clase: {1}",ex.NombreMetodo,ex.NombreClase);

            while (!(ex.InnerException is null))
            {
                ex = (CompetenciaNoDisponibleException)ex.InnerException;
                sb.AppendFormat("\n{0,-60} Metodo: {1,-15} de la Clase: {2,-15}",ex.Message,ex.nombreMetodo,ex.nombreClase);
            } 

            return sb.ToString();
        }
    }
}
