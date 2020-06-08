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
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
        }
        public static double GetCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region Conversión

        public static implicit operator Peso(double d)
        {
            Peso p1 = new Peso(d);
            return p1;
        }
        public static explicit operator Dolar(Peso p)
        {

            Dolar do1 = new Dolar(p.cantidad / Peso.GetCotizacion());
            return do1;
        }

        public static explicit operator Euro(Peso p)
        {
            //Euro eu = new Euro((p.GetCantidad() / Peso.GetCotizacion()) / Euro.GetCotizacion());
            return (Euro)((Dolar)p);
        }

        #endregion

        #region Operadores Comparación

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
            return p == (Peso)d;
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return p == (Peso)e;
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad == p2.cantidad;
        }

        #endregion

        #region Operadores Matemáticos

        public static Peso operator -(Peso p, Dolar d)
        {
            Peso pe1 = new Peso(p.GetCantidad() - (p = (Peso) d).GetCantidad());
            return pe1;
        }
        public static Peso operator -(Peso p, Euro e)
        {
            Peso pe1 = new Peso(p.GetCantidad() - (p = (Peso)e).GetCantidad());
            return pe1;
        }
        public static Peso operator +(Peso p, Euro e)
        {
            Peso pe1 = new Peso(p.GetCantidad() + (p = (Peso)e).GetCantidad());
            return pe1;
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            Peso pe1 = new Peso(p.GetCantidad() + (p = (Peso)d).GetCantidad());
            return pe1;
        }

        #endregion
    }
}
