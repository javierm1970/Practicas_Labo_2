using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        public byte nota1;
        public byte nota2;
        public float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        static Random rnd;

        public void CalcularFinal()
        {

            if (!(this.nota1 >= 4 && this.nota2 >= 4))
            {
                this.notaFinal = -1;
            }
            else
            {
                rnd = new Random();
                this.notaFinal = rnd.Next(1,10);
                
            }

        }

        public void Estudiar(byte nota1,byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            
            CalcularFinal();
        
        }

        public void Mostrar()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("Apellido: {0}", this.apellido);
            Console.WriteLine("Nombre  : {0}", this.nombre);
            Console.WriteLine("Legajo  : {0}", this.legajo);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Nota1   : {0}", this.nota1);
            Console.WriteLine("Nota2   : {0}", this.nota2);
            Console.WriteLine("-----------------------------------------"); ;
            Console.WriteLine("Nota F  : {0}", this.notaFinal);
            Console.WriteLine("*****************************************");
        }




    }
}
