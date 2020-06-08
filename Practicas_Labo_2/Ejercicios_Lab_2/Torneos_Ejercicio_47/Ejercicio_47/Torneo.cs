using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class Torneo <T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        private Random rnd;

        public Torneo()
        {
            equipos = new List<T>();
            rnd = new Random();
            
        }
        public string JugarPartido
        {
            get
            {
                T equipo1;
                T equipo2;
                do
                {
                    equipo1 = this.equipos.ElementAt(rnd.Next((int)this.equipos.Count));
                    
                    equipo2 = this.equipos.ElementAt(rnd.Next((int)this.equipos.Count));
                    
                } while (equipo1==equipo2);

                return this.CalcularResultado(equipo1, equipo2);
            }
        }
        public Torneo(string nombre)
        {
            this.nombre = nombre;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("\nTorneo: {0} ", this.nombre));
            sb.Append("\n");
            sb.Append('-', 60);
            sb.Append("\n");
            foreach (T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularResultado(T equipo1, T equipo2)
        {
            this.rnd = new Random();

            int tanteo1 = rnd.Next(10);
            Thread.Sleep(150);
            int tanteo2 = rnd.Next(10);

            return string.Format("\n{0} {1} - {2} {3}", equipo1.Nombre, tanteo1, tanteo2, equipo2.Nombre);
        }
        public static bool operator ==(Torneo<T> equipos , Equipo equipo)
        {
            foreach (Equipo item in equipos.equipos)
            {
                if (item.Nombre==equipo.Nombre &&
                    item.FechaCreacion==equipo.FechaCreacion)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> equipos, Equipo equipo)
        {
            return !(equipos==equipo);
        }
        public static bool operator +(Torneo<T> equipos, Equipo equipo)
        {
            if (equipos==equipo)
            {
                return false;
            }
            equipos.equipos.Add((T)equipo);
            return true;
        }


    }
}
