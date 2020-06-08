using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Billetes
{
    public class Dolar
    {
        double cantidad;
        static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        public static void SetCotizacion(double cotizacion)
        {
            Dolar.cotizRespectoDolar = Convert.ToDouble(cotizacion);
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region Conversiones

        public static explicit operator Euro(Dolar d)
        {
            Euro eu = new Euro(d.GetCantidad() / Euro.GetCotizacion());
            return eu;
        }

        public static explicit operator Peso(Dolar d)
        {
            Peso pe = new Peso(d.GetCantidad() * Peso.GetCotizacion());
            return pe;
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        #endregion

        #region Operadores

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static bool operator == (Dolar d, Euro e)
        {
            return (d.GetCantidad() == (Dolar)e);
        }
        public static bool operator == (Dolar d, Peso p)
        {
            return (d.GetCantidad() == (Dolar)p);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad() == d2.GetCantidad());
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
        }

        #endregion
    }
}
