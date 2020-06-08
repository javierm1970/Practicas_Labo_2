using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        private float duracion;
        private string nroDestino;
        private string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public abstract float CostoLlamada { get; }
        
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


        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0,-14}  {1,-14}  {2,-14}",this.nroOrigen,this.nroDestino,this.duracion);
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int respuesta;
            if (llamada1.duracion > llamada2.duracion)
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
            return respuesta;
        }
        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Equals(llamada2) 
                && llamada1.nroOrigen==llamada2.nroOrigen && llamada1.nroDestino==llamada2.nroDestino)
            {
                return true;
            }
            return false;
        } 
        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }    
        
    }
}
