using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Billetes
{
    public class Peso
    {
        double cantidad;
        static double cotizRespectoDolar;

        static Peso()
        {
            Peso.cotizRespectoDolar = 38.33;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
            Peso.cotizRespectoDolar = 38.33;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
        }
        public static double GetCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }
        public static void SetCotizacion(double cotizacion)
        {
            Peso.cotizRespectoDolar = Convert.ToDouble(cotizacion);
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region Conversiones

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return new Euro (p.GetCantidad() / Peso.GetCotizacion() / Euro.GetCotizacion());
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        #endregion

        #region Operadores

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Peso p, Dolar d)
        {
            return (p.GetCantidad() == (Peso)d);
        }
        public static bool operator == (Peso p, Euro e)
        {
            return (p.GetCantidad() == (Peso)e);
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            return (p1.GetCantidad() == p2.GetCantidad());
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() - ((Peso) d).GetCantidad());
        }
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() - ((Peso)e).GetCantidad());
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() + ((Peso)e).GetCantidad());
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() + ((Peso)d).GetCantidad());
        }
        #endregion
    }
}
