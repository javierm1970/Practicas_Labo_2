using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_69_Form
{
    public partial class FrmPrincipal : Form
    {
        public static FrmMostrar frmMostrar;
        public static FrmTestDelegados frmTestDelegados;

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.mostrarToolStripMenuItem.Enabled = false;
            this.Text = "Principal";
            this.Name = "FrmPrincipal";
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmTestDelegados is null || frmTestDelegados.IsDisposed==true)
            {
                frmTestDelegados = new FrmTestDelegados();
                frmTestDelegados.MdiParent = this;
                frmTestDelegados.Text = "Form Test Delegados";
                frmTestDelegados.Show();
            }
            
            this.mostrarToolStripMenuItem.Enabled = true;
        }
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMostrar is null || frmMostrar.IsDisposed==true)
            {
                frmMostrar = new FrmMostrar();
                frmMostrar.MdiParent = this;
                frmMostrar.Text = "Form Mostrar";
                frmMostrar.Show(); 
            }
        }
    }
}
