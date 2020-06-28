using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Alumno
    {
        public delegate string ruta();
        private string apellido;
        private int dni;
        private string fotoAlumno;
        private string nombre;
        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fotoAlumno = ruta;
            this.dni = dni;
        }
        public string Nombre 
        {
            get {return this.nombre;}
            set{this.nombre = value;}
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string Ruta 
        { 
            get { return this.fotoAlumno; } 
            set { this.fotoAlumno = value; } 
        }
        public int DNI 
        { 
            get {return this.dni; } 
            set {this.dni = value; } 
        }



    }
}
