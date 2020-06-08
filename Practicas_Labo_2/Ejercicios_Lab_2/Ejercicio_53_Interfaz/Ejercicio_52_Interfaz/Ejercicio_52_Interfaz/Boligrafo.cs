using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52_Interfaz 
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }
        public ConsoleColor Color
        {
            get
            {
                
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }
        public EscrituraWrapper Escribir(string texto)
        {
            if (this.UnidadDeEscritura>0)
            {
                this.UnidadDeEscritura -= (float)(texto.Length * 0.3);
                if (this.UnidadDeEscritura < 0)
                {
                    this.UnidadDeEscritura = 0;
                } 
            }
            else
            {
                texto = "";
            }

            return new EscrituraWrapper(texto, this.Color);
        }
        public bool Recargar(int unidades)
        {
            this.UnidadDeEscritura = +unidades;
            return true;
        }
        public override string ToString()
        {
            return string.Format("Color: {0} / Nivle de Tinta: {1}",this.Color,this.UnidadDeEscritura);
        }
    }
}
