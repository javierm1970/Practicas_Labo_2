using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_21_Biblioteca;

namespace Ejercicio_21_Biblioteca
{
    public class Peso
    {
        double cantidad;
        static double cotizRespectoDolar;

        private Peso()
        {
            this.cantidad = 1;
            Peso.cotizRespectoDolar = (this.cantidad - 273.15) * (9.0 / 5.0) + 32;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad; 
            Peso.cotizRespectoDolar = (this.cantidad - 273.15) * (9.0 / 5.0) + 32;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            this.cantidad = cantidad;
            Peso.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Peso p)
        {

            Dolar do1 = new Dolar((p.GetCantidad() - 273.15 ) * (9.0 / 5.0) + 32);
            return do1;
        }

        public static explicit operator Euro(Peso p)
        {
            Euro eu = new Euro(p.GetCantidad() - 273.15);
            return eu;
        }

        public static double GetCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Peso(double d)
        {
            Peso p1 = new Peso((d - 32) * (5.0 / 9.0) + 273.15);
            return p1;
        }
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
            if (p.GetCantidad() == (p = (Peso)d).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Peso p, Euro e)
        {
            if (p.GetCantidad() == (p = (Peso)e).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            if (p1.GetCantidad() == p2.GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            Peso pe1 = new Peso(Math.Round(p.GetCantidad() - (p = (Peso)d).GetCantidad()));
            return pe1;
        }
        public static Peso operator -(Peso p, Euro e)
        {
            Peso pe1 = new Peso(Math.Round(p.GetCantidad() - (p = (Peso)e).GetCantidad()));
            return pe1;
        }
        public static Peso operator +(Peso p, Euro e)
        {
            Peso pe1 = new Peso(Math.Round(p.GetCantidad() + (p = (Peso)e).GetCantidad()));
            return pe1;
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            Peso pe1 = new Peso(Math.Round(p.GetCantidad() + (p = (Peso)d).GetCantidad()));
            return pe1;
        }
    }
}
