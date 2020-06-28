using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Ejercicio_67_Eventos;

namespace Ejercicio_67_Form
{
    public partial class Form2 : Form
    {
        Temporizador temp1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            temp1 = new Temporizador();
            temp1.eventoTiempo += this.AcutalizaReloj;
            temp1.Intervalo = 250;
            temp1.Activo = true;
        }

        public delegate void del();
        public void AcutalizaReloj()
        {
            if (this.lblReloj.InvokeRequired)
            {
                del d = new del(this.AcutalizaReloj);
                this.Invoke(d);
            }
            else
            {
                this.lblReloj.Text = DateTime.Now.ToString();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            temp1.Activo = false;
        }
    }
}
