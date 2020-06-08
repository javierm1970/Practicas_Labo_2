using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Form_Convertir_Monedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button1.Visible = false;
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Focus();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if (button5.Image=)
            button1.Visible = true;
            button5.Visible = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dolar do1;
            Peso pe1;
            Euro eu2 = new Euro(double.Parse(textBox1.Text));
            
            do1 = (Dolar)eu2;
            pe1 = (Peso)do1;

            double dolar1=do1.GetCantidad();
            double peso1=pe1.GetCantidad();
            double euro1=eu2.GetCantidad();


            label8.Text = eu2.GetCantidad().ToString(); 
            label9.Text = do1.GetCantidad().ToString(); 
            label10.Text = pe1.GetCantidad().ToString(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Peso pe1;
            Dolar do1 = new Dolar(double.Parse(textBox2.Text));
            Euro eu1;

            pe1 = (Peso)do1;
            eu1 = (Euro)do1;

            label11.Text = eu1.GetCantidad().ToString();
            label12.Text = do1.GetCantidad().ToString();
            label13.Text = pe1.GetCantidad().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dolar do1;
            Peso pe1 = new Peso(double.Parse(textBox3.Text));
            Euro eu1;

            do1 = (Dolar)pe1;
            eu1 = (Euro)do1;

            label14.Text = eu1.GetCantidad().ToString();
            label15.Text = do1.GetCantidad().ToString();
            label16.Text = pe1.GetCantidad().ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            double param1;

            if (!(double.TryParse(textBox4.Text,out param1)))
            {
                textBox4.Text = "";
                textBox4.Focus();
            }
            
            Euro.SetCotizacion(param1);
            textBox4.Text = Euro.GetCotizacion().ToString();

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            Dolar.SetCotizacion(Convert.ToDouble(textBox5.Text));
            textBox5.Text = " " + (Dolar.GetCotizacion().ToString());

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            Peso.SetCotizacion(Convert.ToDouble(textBox6.Text));
            textBox6.Text = " " + (Peso.GetCotizacion());

        }

    }
}
