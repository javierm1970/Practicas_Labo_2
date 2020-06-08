using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        private short cantidadJugadores;
        private string nombre;
        private List <Jugador> jugadores;
        private Equipo()
        {
            this.jugadores = new List<Jugador>(); 
        }
        public Equipo(short cantidadJugadores, string nombreEquipo) : this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombreEquipo;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool encontrado = false;
            bool incorporado = false;
            if (e.jugadores.Count() < e.cantidadJugadores)
            {
                foreach (Jugador jugAux in e.jugadores)
                {
                    if (jugAux == j)
                    {
                        encontrado = true;
                        break;
                    }
                }
                if (!(encontrado))
                {
                    e.jugadores.Add(j);
                    incorporado = true;
                }
            }
            return incorporado;
        }
    }
}
