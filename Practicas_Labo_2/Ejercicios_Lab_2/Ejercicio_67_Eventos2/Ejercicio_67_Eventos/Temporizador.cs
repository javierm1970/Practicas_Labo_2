using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_67_Eventos
{
    public sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        public delegate void encargadoTiempo();
        public event encargadoTiempo eventoTiempo;

        public bool Activo
        {
            get
            {
                if (this.hilo is null || !(this.hilo.IsAlive))
                {
                    return false;
                }
                return true;
            }
            set
            {
                if (value)
                {
                    if (this.hilo is null)
                    {
                        this.hilo = new Thread(this.Corriendo);
                        this.hilo.Start();
                    }
                    else
                    {
                        if (!(this.hilo.IsAlive))
                        {
                            this.hilo = new Thread(this.Corriendo);
                            this.hilo.Start();
                        }
                    }
                }
                else
                {
                    if (!(this.hilo is null))
                    {
                        if (this.hilo.IsAlive)
                        {
                            this.hilo.Abort();
                        } 
                    }
                }
            }
        }
        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }
        private void Corriendo()
        {
            do
            {
                Thread.Sleep(this.intervalo);
                if (!(this.eventoTiempo is null))
                {
                    this.eventoTiempo.Invoke(); 
                }
            } while (true);
        }
    }
}
