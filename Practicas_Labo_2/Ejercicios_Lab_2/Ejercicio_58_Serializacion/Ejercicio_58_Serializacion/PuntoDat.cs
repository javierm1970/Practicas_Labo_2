using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio_58_Serializacion
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat> 
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }
        bool IArchivos<PuntoDat>.Guardar(string ruta, PuntoDat objeto)
        {
            bool existe=true;
            Stream fs;
            BinaryFormatter ser;

            if(objeto.ValidarArchivo(ruta, existe))
            {
                fs = new FileStream(ruta, FileMode.Create);

                ser = new BinaryFormatter();

                ser.Serialize(fs, (PuntoDat)objeto);

                fs.Close();
            }
            return existe;

        }
        bool IArchivos<PuntoDat>.GuardarComo(string ruta, PuntoDat objeto)
        {
            StreamWriter nr;
            if (ValidarArchivo(ruta, false))
            {
                nr = new StreamWriter(ruta);
                nr.Write(objeto.contenido);
                nr.Close();
                ((IArchivos<PuntoDat>)this).Guardar(ruta, objeto);
            }
            else
            {
                ((IArchivos<PuntoDat>)this).Guardar(ruta, objeto);
            }
            return true;
        }
        public PuntoDat Leer(string ruta)
        {
            PuntoDat aux = new PuntoDat();
            FileStream fs; // Objeto que leerá en binario.
            BinaryFormatter ser; // Objeto que Deserializará.
            if (ValidarArchivo(ruta, true))
            {
                //Se indica ubicación del archivo binario y el modo.
                fs = new FileStream(ruta, FileMode.Open);
                
                //Se crea el objeto deserializador.
                ser = new BinaryFormatter();

                //Deserializa el archivo contenido en fs, lo guarda en aux.
                aux = (PuntoDat)ser.Deserialize(fs);
                
                fs.Close();
            }
            return aux;
        }
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            //validaExistencia = false;

            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".dat")
                    {
                        validaExistencia = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un dat.");
                    }
                }
            }
            catch (FileNotFoundException e)
            {

                throw new ArchivoIncorrectoException("Archivo no Encontrado",e);
            }
            return validaExistencia;
        }
    }
}
