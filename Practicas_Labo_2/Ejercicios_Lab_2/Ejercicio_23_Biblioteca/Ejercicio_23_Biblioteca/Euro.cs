using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        double cantidad;
        static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 1;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
            //Euro.cotizRespectoDolar = 1;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        public static void SetCotizacion(double cotizacion)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region Conversiones

        public static explicit operator Dolar(Euro e)
        {
            double prueba1 = e.GetCantidad();
            double prueba2 = Euro.GetCotizacion();
            return new Dolar(e.GetCantidad() * Euro.GetCotizacion());
        }
        public static explicit operator Peso(Euro e)
        {
            return new Peso(e.GetCantidad() * Dolar.GetCotizacion() * Peso.GetCotizacion());
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        #endregion

        #region Operadores

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator == (Euro e, Dolar d)
        {
            return (e.GetCantidad() == (Euro)d);
        }
        public static bool operator == (Euro e, Peso p)
        {
            return (e.GetCantidad() == (Euro)p);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.GetCantidad() == e2.GetCantidad());
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
        }

        #endregion
    }
}
