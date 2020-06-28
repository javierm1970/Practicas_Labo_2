using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_75
{
    public static class EstacionesAnuales
    {
        public enum Estaciones
        {
            Verano, Otoño, Invierno, Primavera
        }
        public static string ObtenerPlacaCronica(this DateTime fecha, Estaciones estacion)
        {
            string resultado;
            DateTime fechaParametro = new DateTime(fecha.Year, fecha.Month, fecha.Day);
            DateTime fechaEstacion;

            if (estacion == Estaciones.Invierno)
            {
                fechaEstacion = new DateTime(2020, 6, 21);
                resultado =  string.Format("faltan {0} días para el Invierno", (fechaEstacion - fechaParametro).TotalDays);
            }
            else if (estacion == Estaciones.Otoño)
            {
                fechaEstacion = new DateTime(2021, 3, 21);
                resultado = string.Format("faltan {0} días para el Otoño", (fechaEstacion - fechaParametro).TotalDays);
            }
            else if (estacion == Estaciones.Primavera)
            {
                fechaEstacion = new DateTime(2020, 9, 21);
                resultado = string.Format("faltan {0} días para la Primavera", (fechaEstacion - fechaParametro).TotalDays);
            }
            else
            {
                fechaEstacion = new DateTime(2020, 12, 21);
                resultado = string.Format("faltan {0} días para el verano", (fechaEstacion - fechaParametro).TotalDays);
            }

            return resultado;
        }
    }
}
