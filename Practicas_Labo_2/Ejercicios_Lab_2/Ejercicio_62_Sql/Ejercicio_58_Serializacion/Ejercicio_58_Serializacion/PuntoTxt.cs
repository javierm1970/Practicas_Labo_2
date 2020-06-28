using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_62
{
    public class PuntoTxt : Archivo, IArchivos<string> 
    {
        bool IArchivos<string>.Guardar(string ruta, string objeto)
        {
            if (ValidarArchivo(ruta,true))
            {
                StreamWriter miEscritura = new StreamWriter(ruta);
                miEscritura.Write(objeto);
                miEscritura.Close(); 
            }
            return true;
        }
        bool IArchivos<string>.GuardarComo(string ruta, string objeto)
        {
            StreamWriter nr;
            
            if(ValidarArchivo(ruta, false))
            {
                nr = new StreamWriter(ruta);
                nr.Write(objeto);
                nr.Close();
                ((IArchivos<string>)this).Guardar(ruta, objeto);
            }
            else
            {
                ((IArchivos<string>)this).Guardar(ruta, objeto);
            }
            return true;
        }
        string IArchivos<string>.Leer(string ruta)
        {
            string retorno;
            if(this.ValidarArchivo(ruta, true))
            {
                StreamReader sr = new StreamReader(ruta);
                retorno = sr.ReadToEnd();
                sr.Close();
                return retorno;
            }
            return string.Empty;
        }
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            //validaExistencia = false;

            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".txt")
                    {
                        validaExistencia = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un txt.");
                    }
                }
            }
            catch (FileNotFoundException e)
            {

                throw new ArchivoIncorrectoException("Archivo no Encontrado", e);
            }
            return validaExistencia;
        }
    }
}
