using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
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
        private void AgregarLLamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float resultado = 0;
            foreach (Llamada item in this.listaDeLlamadas)
            {
                resultado += item.CostoLlamada;
                
                //switch (tipo)
                //{
                //    case Llamada.TipoLlamada.Local:
                //        if (item is Local)
                //        {
                //            resultado += item.CostoLlamada;
                //        }
                //        break;
                //    case Llamada.TipoLlamada.Provincial:
                //        if (item is Provincial)
                //        {
                //            resultado += item.CostoLlamada;
                //        }
                //        break;
                //}
            }
            return resultado;
        }
        //public string Mostrar()
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.razonSocial);
            sb.AppendFormat("\nG Total: {0}   \tG Local: {1}   \tG Provincial: {2}  "
                , GananciaPorTotal, GananciaPorLocal, GananciaPorProvincial);
            sb.Append("\n");
            sb.Append('*', 80);
            sb.Append("\nNum Origen \tNro Destino \tDuracion \tCosto\n");
            
            foreach (Llamada item in this.listaDeLlamadas)
            {
                if (item is Local)
                {
                    sb.Append(item.ToString());
                }
                else if (item is Provincial)
                {
                    sb.Append(item.ToString());
                }
            }
            sb.Append("\n");
            sb.Append('*', 80);
            return sb.ToString();
        }
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada item in c.listaDeLlamadas)
            {
                if (llamada==item)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if (!(c == llamada))
            {
                c.AgregarLLamada(llamada);
                return c;
            }
            throw new CentralitaException("Ya esta cargada la llamada", "Llamada", "Operador +");
            //return c;
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
