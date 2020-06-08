using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52_Interfaz
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }
        ConsoleColor IAcciones.Color
        {
            get
            {
                ConsoleColor colorLapiz = ConsoleColor.Gray;
                return colorLapiz;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina =value;
            }
        }
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            if (((IAcciones)this).UnidadDeEscritura > 0)
            {
                ((IAcciones)this).UnidadDeEscritura -= (float)(texto.Length * 0.1);
                if (((IAcciones)this).UnidadDeEscritura < 0)
                {
                    ((IAcciones)this).UnidadDeEscritura = 0;
                }
            }
            else
            {
                texto = "";
            }
            return new EscrituraWrapper(texto,((IAcciones)this).Color);
        }
        bool IAcciones.Recargar(int unidades)
        {
            ((IAcciones)this).UnidadDeEscritura = +unidades;
            return true;
        }
        public override string ToString()
        {
            return string.Format("Color: {0} / Tamaño de Mina: {1}",
                ((IAcciones)this).Color,((IAcciones)this).UnidadDeEscritura);
        }
    }
}
