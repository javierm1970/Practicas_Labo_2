using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Llamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        } 
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0,-14}  {1,-14}  {2,-14}  ",
                this.nroOrigen,this.nroDestino,this.duracion);
            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int respuesta;
            if (llamada1.Duracion > llamada2.duracion)
            {
                respuesta = 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                respuesta = -1;
            }
            else
            {
                respuesta = 0;
            }
            return -respuesta;
        }
    }
}
