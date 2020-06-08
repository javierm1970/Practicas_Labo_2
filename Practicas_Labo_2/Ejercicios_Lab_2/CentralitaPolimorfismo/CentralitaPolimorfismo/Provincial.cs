using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
            :this(llamada.NroOrigen,miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            float resultado=0;
            switch (franjaHoraria)
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
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendFormat(" {0}  {1}\n", this.CostoLlamada,this.franjaHoraria);
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Provincial)
                return true;
            return false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
