using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;

            }

        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float resultado = 0;
            foreach (Llamada item in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (item is Local)
                        {
                            resultado += ((Local)item).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            resultado += ((Provincial)item).CostoDeLlamada;
                        }
                        break;
                }
            }
            return resultado;
        }
        
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.razonSocial);
            sb.AppendFormat("\nG Total: {0}   \tG Local: {1}   \tG Provincial: {2}  "
                ,GananciaPorTotal,GananciaPorLocal,GananciaPorProvincial);
            sb.Append("\n");
            sb.Append('*', 80);            
            sb.Append("\nNum Origen \tNro Destino \tDuracion \tCosto\n");           
            
            foreach (Llamada item in this.listaDeLlamadas)
            {
                if (item is Local)
                {
                    sb.Append(((Local)item).Mostrar());
                }
                else if (item is Provincial)
                {
                    sb.Append(((Provincial)item).Mostrar());
                }
            }
            sb.Append("\n");
            sb.Append('*', 80);
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
