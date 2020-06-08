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
    public partial class FrmMostrar : Form
    {
        public Provincial.TipoLlamada tipoLlamada;
        public List<Llamada> centralita;
        public FrmMostrar()
        {
            InitializeComponent();
        }
        public FrmMostrar(List<Llamada> centralitaMenu) : this()
        {
            this.centralita = centralitaMenu;
        }
        public Provincial.TipoLlamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value;
            }
        }
        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if (!(centralita is null))
            {
                
                foreach (Llamada item in centralita)
                {
                    switch (this.tipoLlamada)
                    {
                        case Llamada.TipoLlamada.Local:
                            if (item is Local)
                            {
                                richTextBox1.Text += item.ToString(); 
                            }
                            break;
                        case Llamada.TipoLlamada.Provincial:
                            if (item is Provincial)
                            {
                                richTextBox1.Text += item.ToString();
                            }
                            break;
                        case Llamada.TipoLlamada.Todas:
                            richTextBox1.Text += item.ToString();
                            break;
                    }
                }
            }
        }

        private void FrmMostrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
