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
        public Centralita centralita;
        public FrmMostrar()
        {
            InitializeComponent();
        }
        public FrmMostrar(Centralita centralitaMenu) : this()
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
                richTextBox1.Text = "";
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Llamadas Totales");
                sb.Append('x', 80);
                sb.AppendFormat("\n");
                sb.AppendLine(centralita.ToString());

                if (this.tipoLlamada == Llamada.TipoLlamada.Provincial)
                {
                    sb.AppendFormat("\nTotal de llamadas Provinciales: {0}",centralita.GananciaPorProvincial.ToString());
                    richTextBox1.Text += sb.ToString();
                }        
                else if (this.tipoLlamada == Llamada.TipoLlamada.Local)
                {
                    sb.AppendFormat("\nTotal de llamadas Locales: {0}", centralita.GananciaPorLocal.ToString());
                    richTextBox1.Text += sb.ToString();
                }
                else if (this.tipoLlamada == Llamada.TipoLlamada.Todas)
                {
                    sb.AppendFormat("\nTotal de llamadas Totales: {0}", centralita.GananciaPorTotal.ToString());
                    richTextBox1.Text += sb.ToString();
                }
                /*
                foreach (Llamada item in centralita.lista)
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
                }*/
            }
        }

        private void FrmMostrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
