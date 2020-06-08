using CentralitaPolimorfismo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

//namespace CentralitaPolimorfismo

namespace Form_Centralita_Polimorfismo
{
    public partial class FrmLlamador : Form
    {
        public Centralita centralita;
        private Random rndDuracion;
        private Random rndCosto;
        public FrmLlamador()
        {
            InitializeComponent();
        }
        public FrmLlamador(Centralita centralitaMenu):this()
        {
            //this.centralita = new List<Llamada>();
            this.centralita = centralitaMenu;
        }
        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            
            //centralita = new FrmLlamador(new List<Llamada>());
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            textNroOrigen.Text = "F.Varela";
            rndDuracion = new Random();
            rndCosto = new Random();
        }
        public Centralita CentralitaMenu
        {
            get
            {
                return this.centralita;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textNroDestino.Text += "1";
            textNroDestino.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textNroDestino.Text += "2";
            textNroDestino.Focus();
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            textNroDestino.Text += "9";
            textNroDestino.Focus();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            textNroDestino.Text += "3";
            textNroDestino.Focus();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            textNroDestino.Text += "4";
            textNroDestino.Focus();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            textNroDestino.Text += "5";
            textNroDestino.Focus();
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            textNroDestino.Text += "6";
            textNroDestino.Focus();
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            textNroDestino.Text += "7";
            textNroDestino.Focus();
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            textNroDestino.Text += "8";
            textNroDestino.Focus();
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            textNroDestino.Text += "*";
            textNroDestino.Focus();
        }
        private void button12_Click_1(object sender, EventArgs e)
        {
            textNroDestino.Text += "#";
            textNroDestino.Focus();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textNroDestino.Text += "0";
            textNroDestino.Focus();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNroDestino.Text = string.Empty;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textNroDestino_TextChanged(object sender, EventArgs e)
        {
            cmbFranja.Enabled = true;
            if (textNroDestino.Text != string.Empty)
            {
                if (!(textNroDestino.Text[0] == '#'))
                {
                    cmbFranja.Enabled = false;
                } 
            }
        }
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (textNroDestino.Text != string.Empty)
            {
                try
                {
                    if (!(textNroDestino.Text[0] == '#'))
                    {
                        Llamada llamadaActual = new Local(
                            textNroOrigen.Text, rndDuracion.Next(1, 50), textNroDestino.Text,
                            rndDuracion.Next(1, 6));

                        centralita = (centralita + llamadaActual);
                    }
                    else
                    {
                        Provincial.Franja franja;
                        Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
                        Llamada llamadaActual = new Provincial(
                            textNroOrigen.Text, franja, rndDuracion.Next(1, 50),
                            textNroDestino.Text);

                        centralita = centralita + llamadaActual;
                        //centralita.Add(llamadaActual);
                    }
                }
                catch (CentralitaException)
                {
                    MessageBox.Show("No se puede Agregar, ya fue cargada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //throw;
                }
            }
            MessageBox.Show("finalizo la llamada...");
            textNroDestino.Text = string.Empty;
        }
    }
}
