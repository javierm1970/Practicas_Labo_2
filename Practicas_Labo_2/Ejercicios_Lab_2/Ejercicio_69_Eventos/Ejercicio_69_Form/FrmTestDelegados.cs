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

namespace Ejercicio_69_Form
{
    public partial class FrmTestDelegados : Form
    {
        public event FrmMostrar.delegado eventoMostrar;
        public FrmTestDelegados()
        {
            InitializeComponent();
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (!(FrmPrincipal.frmMostrar is null))
            {
                eventoMostrar += FrmPrincipal.frmMostrar.ActualizarNombre;
                eventoMostrar.Invoke(this.textBoxNombre.Text);
            }
        }
    }
}
