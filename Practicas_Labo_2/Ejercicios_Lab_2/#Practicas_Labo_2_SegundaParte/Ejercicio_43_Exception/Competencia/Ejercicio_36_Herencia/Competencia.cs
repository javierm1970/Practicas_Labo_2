﻿using Ejercicio_36_Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36_Biblioteca
{
    public class Competencia
    {
        public enum TipoVehiculo
        {
            AutosF1, MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> vehiculosCarrera;
        private TipoVehiculo tipoCompetencia;

        private Competencia()
        {
            this.vehiculosCarrera = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas,TipoVehiculo tipoVehiculo) :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipoCompetencia = tipoVehiculo;
        }
        public TipoVehiculo TipoCompetencia
        {
            get
            {
                return tipoCompetencia;
            }
            set
            {
                this.tipoCompetencia = value;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('*', 80);
            sb.Append("\nCantidad de Competidores:"+this.cantidadCompetidores);
            sb.Append("\nCantidad de Vueltas: " + this.cantidadVueltas);
            sb.AppendFormat("\nTipo de Competencia: {0}", this.TipoCompetencia);
            sb.Append("\n");
            sb.Append('*', 80);
            sb.Append("\n");
            
            foreach (VehiculoDeCarrera item in this.vehiculosCarrera)
            {
                sb.AppendFormat(item.MostrarDatos());
            }

            return sb.ToString();
        }

        #region Operadores 

        public static bool operator +(Competencia c,VehiculoDeCarrera a)
        {
            if (c.vehiculosCarrera.Count < c.cantidadCompetidores)
            {
                if (c.TipoCompetencia==TipoVehiculo.AutosF1 && a is AutoF1 ||
                    c.TipoCompetencia==TipoVehiculo.MotoCross && a is MotoCross)
                {
                    if (!(c == a))
                    {
                        c.vehiculosCarrera.Add(a);
                        a.EnCompetencia = true;
                        a.CantidadCombustible = a.CantidadCombustible;
                        a.VueltasRestantes = c.cantidadVueltas;
                        return true;
                    } 
                }
            }
            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (c.vehiculosCarrera.Count < c.cantidadCompetidores)
            {
                if (c == a)
                {
                    c.vehiculosCarrera.Remove(a);
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Competencia c,VehiculoDeCarrera a)
        {
            foreach (VehiculoDeCarrera item in c.vehiculosCarrera)
            {
                if (item == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        #endregion

    }
}
