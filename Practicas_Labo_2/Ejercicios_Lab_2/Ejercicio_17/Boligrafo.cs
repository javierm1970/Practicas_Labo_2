using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_2
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private short tinta;
        private ConsoleColor color;
        
        public Boligrafo(short tinta)
        {
            this.tinta = tinta;
        }
        
        public ConsoleColor GetColor(string colorTinta)
        {
            
            if (colorTinta == "rojo")
            {
                return ConsoleColor.Red;
            }
            else if (colorTinta=="azul")
            {
                return ConsoleColor.Blue;
            }
            else
            {
                return ConsoleColor.White;
            }

        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            
            this.tinta = (short)(this.tinta +tinta);
            
            if (this.tinta < 0)
            {
                this.tinta = 0;
            }
            else if (this.tinta > 100)
            {
                this.tinta = 100;
            }

        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short tinta, out string gasto)
        {
            short carga;
            int calculoGasto;
            string gs = "";

            carga = (short)(this.GetTinta() - tinta);

            if (this.GetTinta() > 0)
            {
                if (carga < 0)
                {
                    calculoGasto = this.tinta;
                }
                else
                {
                    calculoGasto = tinta;
                }

                for (int i = 0; i < calculoGasto; i++)
                {
                    gs = gs + '*'.ToString();
                }

                gasto = gs;
                
                SetTinta((short)(tinta*(-1)));
                return true;
            }
            else
            {
                gasto = "";
                SetTinta((short)(tinta * (-1)));
                return false;
            }
        }
    }
}
