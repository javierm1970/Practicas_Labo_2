using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        double cantidad;
        static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1.00;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region Conversiones

        public static implicit operator Dolar(double d)
        {
            Dolar d1 = new Dolar(d);
            return d1;
        }
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

        #endregion
        
        #region Operadores de Comparación

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
            return d == (Dolar)e;
        }
        public static bool operator == (Dolar d, Peso p)
        {
            return d == (Dolar)p;
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad; 
        }

        #endregion

        #region Operadores Matemáticos

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar do1 = new Dolar(d.GetCantidad() - (d = (Dolar)e).GetCantidad());
            return do1;
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar do1 = new Dolar(d.GetCantidad() - (d = (Dolar)p).GetCantidad());
            return do1;
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar do1 = new Dolar(d.GetCantidad() + (d = (Dolar)e).GetCantidad());
            return do1;
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar do1 = new Dolar(d.GetCantidad() + (d = (Dolar)p).GetCantidad());
            return do1;
        }

        #endregion
    }
}
