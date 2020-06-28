using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_71_Form
{
    public partial class FrmDatosAlumno4 : Ejercicio_71_Form.FrmAltaAlumno
    {
        public delegate void rutaFotoAlumno(Entidades.Alumno alumno);
        public FrmDatosAlumno4()
        {
            InitializeComponent();
            
        }
        public void ActualizaAlumno(Entidades.Alumno alumno)
        {
            this.textBoxNombre.Text = alumno.Nombre;
            this.textBoxApellido.Text = alumno.Apellido;
            this.textBoxDNI.Text = alumno.DNI.ToString();
            this.textBoxFoto.Text = alumno.Ruta;
            this.pictureBoxFotoAlumno.ImageLocation = alumno.Ruta;
        }
    }
}
