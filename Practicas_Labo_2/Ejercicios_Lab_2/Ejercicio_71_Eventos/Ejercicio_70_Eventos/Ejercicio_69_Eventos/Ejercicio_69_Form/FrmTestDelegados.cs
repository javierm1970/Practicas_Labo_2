using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_71_Form
{
    public partial class FrmTestDelegados : Form
    {
        public event FrmMostrar.delegado eventoMostrar;
        public event FrmMostrar.delegadoFoto eventoMostrarFoto;
        private string miPath; 
        public FrmTestDelegados()
        {
            InitializeComponent();
            miPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.openFileDialogFoto.InitialDirectory = miPath;
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (!(FrmPrincipal.frmMostrar is null))
            {
                eventoMostrar += FrmPrincipal.frmMostrar.ActualizarNombre;
                eventoMostrar.Invoke(this.textBoxNombre.Text);
            }
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            if (this.openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                this.miPath = openFileDialogFoto.FileName;

            }
            if (!(FrmPrincipal.frmMostrar is null))
            {
                eventoMostrarFoto += FrmPrincipal.frmMostrar.ActualizarFoto;
                eventoMostrarFoto.Invoke(this.miPath);
            }

        }
    }
}
