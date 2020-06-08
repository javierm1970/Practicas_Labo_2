using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_31_Biblioteca;

namespace Ejercicio_31_Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }

        public string PropiedadNombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int PropiedadNumero
        {
            get
            {
                return this.numero;
            }
        }

        #region Opèradores

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return (c1.numero == c2.numero);
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1==c2);
        }


        #endregion


    }
}
