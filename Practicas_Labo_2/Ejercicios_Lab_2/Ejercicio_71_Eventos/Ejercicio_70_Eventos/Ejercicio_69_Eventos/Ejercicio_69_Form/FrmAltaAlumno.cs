using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_69_Form;
using Entidades;

namespace Ejercicio_71_Form
{
    public partial class FrmAltaAlumno : Form
    {
        private string ruta;
        private OpenFileDialog openFileDialogFotoAlumno;
        public event FrmDatosAlumno4.rutaFotoAlumno pasaAlumno;
        public FrmAltaAlumno()
        {
            InitializeComponent();
            openFileDialogFotoAlumno = new OpenFileDialog();
            this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.openFileDialogFotoAlumno.InitialDirectory = this.ruta;
        }
        private void lblFoto_DoubleClick(object sender, EventArgs e)
        {
            if (this.openFileDialogFotoAlumno.ShowDialog() == DialogResult.OK)
            {
                this.ruta = openFileDialogFotoAlumno.FileName;
                this.textBoxFoto.Text = this.ruta;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dni;
            if (!(int.TryParse(textBoxDNI.Text,out dni)))
            {
                dni = 0;
            }

            Alumno a1 = new Alumno(this.textBoxNombre.Text,
                this.textBoxApellido.Text, dni, textBoxFoto.Text);
            MessageBox.Show("Alta Exitosa...", "Alta de Alumno", MessageBoxButtons.OK);
            pasaAlumno += FrmPrincipal.frmDatosAlumno4.ActualizaAlumno;
            pasaAlumno.Invoke(a1);
        }
    }
}
