using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33_Biblioteca
{
    public class Libro
    {
        private List<string> paginas;

        public string this[int indice]
        {
            get
            {
                if (!(paginas is null))
                {
                    if (indice >= 0 && indice <= paginas.Count)
                    {
                        return paginas[indice];
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                return string.Empty;
            }

            set
            {
                if (paginas is null)
                {
                    paginas = new List<string>();
                }

                // Si el índice es válido.
                if (indice >= 0)
                {
                    /* Si el índice es mayor o igual a cero 
                     * y menor a la cantidad de elementos de la lista. 
                     * Entonces, existe.
                     * Lo modifico.             
                     */
                    if (indice < this.paginas.Count)
                    {
                        this.paginas[indice] = value;
                    }
                    else
                    {
                        /* Si supera o iguala 
                         * a la cantidad de elementos,
                         * Lo agrego.                        
                        */
                        this.paginas.Add(value);
                    }
                }
            }
        }
        public int PropiedadCoutn
        {
            get
            {
                if (!(paginas is null))
                    return paginas.Count;
                else return -1;
            }
        }
    }
}
