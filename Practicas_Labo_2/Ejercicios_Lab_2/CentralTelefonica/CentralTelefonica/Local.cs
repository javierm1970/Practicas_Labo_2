using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo)
            : this(new Llamada(duracion,destino,origen),costo)
        {
            
        }
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar()+" "+this.costo.ToString());
            return sb.ToString();
        }
    }
}
