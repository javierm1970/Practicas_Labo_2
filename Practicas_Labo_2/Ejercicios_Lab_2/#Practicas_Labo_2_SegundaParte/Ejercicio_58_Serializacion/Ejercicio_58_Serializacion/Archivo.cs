using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_58_Serializacion
{
    [Serializable]
    public abstract class Archivo
    {
        protected virtual bool  ValidarArchivo(string ruta, bool validaExistencia)
        {
            if (validaExistencia)
            {
                if (File.Exists(ruta))
                {
                    validaExistencia = true;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            else
            {
                if (!(File.Exists(ruta)))
                {
                    validaExistencia = true;
                }
                else
                {
                    validaExistencia = false;
                }
            }
            return validaExistencia;
        }
    }
}
