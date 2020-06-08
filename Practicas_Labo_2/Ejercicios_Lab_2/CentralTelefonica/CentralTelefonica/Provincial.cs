using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
            :base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :this(miFranja, new Llamada(duracion,destino,origen))
        {

        }
        public float CostoDeLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float resultado=0;            

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    resultado = this.Duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    resultado = this.Duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    resultado = this.Duracion * 0.66f;
                    break;
            }
            
            return resultado;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar() + " "); 
            sb.Append((CalcularCosto()/this.duracion).ToString()+" ");
            sb.Append(this.franjaHoraria.ToString());
            return sb.ToString();
        }
    }
}
