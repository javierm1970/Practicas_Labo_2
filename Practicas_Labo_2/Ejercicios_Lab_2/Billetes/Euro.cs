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
            Euro.cotizRespectoDolar = 1.16;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region Conversión
        
        public static implicit operator Euro(double d)
        {
            Euro eu = new Euro(d);
            return eu;
        }
        public static explicit operator Dolar(Euro e)
        {
            Dolar d = new Dolar(e.GetCantidad() * Euro.GetCotizacion());
            return d;
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }

        #endregion

        #region Operadores de Comparación

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
            return e == (Euro)d;
        }
        public static bool operator == (Euro e, Peso p)
        {
            return e == (Euro)p;
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad==e2.cantidad;
        }

        #endregion

        #region Operadores Matemáticos

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro eu1 = new Euro(e.GetCantidad() - (e = (Euro)d).GetCantidad());
            return eu1;
        }
        public static Euro operator -(Euro e, Peso p)
        {
            Euro eu1 = new Euro(e.GetCantidad() - (e = (Euro)p).GetCantidad());
            return eu1;
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro eu1 = new Euro(e.GetCantidad() + (e = (Euro)d).GetCantidad());
            return eu1;
        }
        public static Euro operator +(Euro e, Peso p)
        {
            Euro eu1 = new Euro(e.GetCantidad() + (e = (Euro)p).GetCantidad());
            return eu1;
        }

        #endregion
    }
}
