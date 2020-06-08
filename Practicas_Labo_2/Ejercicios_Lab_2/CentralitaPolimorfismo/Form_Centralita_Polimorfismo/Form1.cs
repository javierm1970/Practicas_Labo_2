using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorfismo;

namespace Form_Centralita_Polimorfismo
{
    public partial class FrmMenu : Form
    {
        public List<Llamada> centralitaMenu;
        public FrmMenu()
        {
            InitializeComponent();
            centralitaMenu = new List<Llamada>();
        }
        
        private void btnGenLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(centralitaMenu);
            frmLlamador.ShowDialog();
        }

        private void btnFacTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralitaMenu);
            frmMostrar.TipoLlamada = Provincial.TipoLlamada.Todas;
            frmMostrar.Show();
        }

        private void btnFacLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralitaMenu);
            frmMostrar.TipoLlamada = Provincial.TipoLlamada.Local;
            frmMostrar.Show();
        }

        private void btnFacProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralitaMenu);
            frmMostrar.TipoLlamada = Provincial.TipoLlamada.Provincial;
            frmMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
