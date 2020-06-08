using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21_Biblioteca
{
    public class Euro
    {
        double cantidad;
        static double cotizRespectoDolar;

        private Euro()
        {
            this.cantidad = 0;        //(e.GetCantidad() - 32) * (5.0 / 9.0)    
            Euro.cotizRespectoDolar = (float) (this.cantidad - 32) * (5.0 / 9.0);

        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
            Euro.cotizRespectoDolar = (float)(this.cantidad - 32) * (5.0 / 9.0);
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar d = new Dolar(e.GetCantidad() * (9.0 / 5.0) + 32 ); //  Euro.GetCotizacion());
            return d;
        }

        public static explicit operator Peso(Euro e)
        {
            Peso p = new Peso(e.GetCantidad() + 273.15);
            return p;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Euro(double d)
        {
            Euro eu = new Euro((d - 32) * (5.0 / 9.0));
            return eu;
        }

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
        public static bool operator ==(Euro e, Dolar d)
        {
            if (e.GetCantidad() == (e = (Euro)d).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Euro e, Peso p)
        {
            double pru1 = e.GetCantidad();
            double pru2 = (e = (Euro)p).GetCantidad();

            if (e.GetCantidad() == (e = (Euro)p).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            if (e1 == e2)
            {
                return true;
            }
            return false;
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            Euro eu1 = new Euro(Math.Round(e.GetCantidad() - (e = (Euro)d).GetCantidad()));
            return eu1;
        }
        public static Euro operator -(Euro e, Peso p)
        {
            Euro eu1 = new Euro(Math.Round(e.GetCantidad() - (e = (Euro)p).GetCantidad()));
            return eu1;
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro eu1 = new Euro(Math.Round(e.GetCantidad() + (e = (Euro)d).GetCantidad()));
            return eu1;
        }
        public static Euro operator +(Euro e, Peso p)
        {
            Euro eu1 = new Euro(Math.Round(e.GetCantidad() + (e = (Euro)p).GetCantidad()));
            return eu1;
        }


    }
}
