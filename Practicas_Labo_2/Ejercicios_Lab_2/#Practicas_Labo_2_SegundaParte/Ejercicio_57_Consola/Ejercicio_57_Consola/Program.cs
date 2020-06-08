using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio_57_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Javier","Magdaleno");
            Persona persona2;


            try
            {
                Persona.Guardar(persona1);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {

                Console.WriteLine("\n{0}",e.Message);
            }

            persona2 = Persona.Leer();

            Console.WriteLine(persona2.ToString());
            Console.ReadKey();
        }
    }
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static void Guardar(Persona persona)
        {
            Stream fs;
            BinaryFormatter ser;

            fs = new FileStream("D:\\prueba Archivos\\prueba.bin", FileMode.Create);

            ser = new BinaryFormatter();

            ser.Serialize(fs, persona);

            fs.Close();
        }
        public static Persona Leer() 
        {
            Persona aux;
            Stream fs;
            BinaryFormatter ser;

            fs = new FileStream("D:\\prueba Archivos\\prueba.bin", FileMode.Open);
            
            ser = new BinaryFormatter();
            
            aux = (Persona)ser.Deserialize(fs);
            
            fs.Close();

            return aux;
        }
        public override string ToString()
        {
            return string.Format("\nNombre: {0} Apellido: {1}",
                this.nombre,this.apellido);
        }
    }
}
