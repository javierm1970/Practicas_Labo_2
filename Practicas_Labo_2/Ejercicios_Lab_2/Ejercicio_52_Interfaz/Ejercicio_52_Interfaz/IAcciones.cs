using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52_Interfaz
{
    public interface IAcciones
    {
        ConsoleColor Color { get; set; }
        float UnidadDeEscritura { get; set; }
        EscrituraWrapper Escribir(string texto);
        bool Recargar(int unidades);


    }
}
