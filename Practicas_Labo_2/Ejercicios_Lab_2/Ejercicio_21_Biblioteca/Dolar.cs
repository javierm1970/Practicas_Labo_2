using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21_Biblioteca

{
    public class Dolar
    {
        double cantidad;
        static double cotizRespectoDolar;

        private Dolar()
        {
            this.cantidad = 0;
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            this.cantidad = cantidad;
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro eu = new Euro((d.GetCantidad() - 32) * (5.0 / 9.0));
            return eu;
        }

        public static explicit operator Peso(Dolar d)
        {
            Peso pe = new Peso((d.GetCantidad() - 32) * (5.0 / 9.0) + 273.15);
            return pe;
        }


        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar d1 = new Dolar(d * Dolar.GetCotizacion());
            return d1;
        }

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
        public static bool operator ==(Dolar d, Euro e)
        {
            if (d.GetCantidad() == (d = (Dolar)e).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            if (d.GetCantidad() == (d = (Dolar)p).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1 == d2)
            {
                return true;
            }
            return false;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar do1 = new Dolar(Math.Round(d.GetCantidad() - (d = (Dolar)e).GetCantidad()));
            return do1;
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar do1 = new Dolar(Math.Round(d.GetCantidad() - (d = (Dolar)p).GetCantidad()));
            return do1;
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar do1 = new Dolar(Math.Round(d.GetCantidad() + (d = (Dolar)e).GetCantidad()));
            return do1;
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar do1 = new Dolar(Math.Round(d.GetCantidad() + (d = (Dolar)p).GetCantidad()));
            return do1;
        }
    }
}
