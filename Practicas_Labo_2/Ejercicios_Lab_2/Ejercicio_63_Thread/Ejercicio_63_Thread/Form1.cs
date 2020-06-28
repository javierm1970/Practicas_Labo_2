using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio_63_Thread
{
    public partial class Form1 : Form
    {

        Thread hilo1;
        Thread hilo2;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        delegate void delegado();
        delegate void delegado2(Object obj,string s);
        public void ActualizarHora()
        {
            if (this.lnlReloj.InvokeRequired)
            {
                delegado d = new delegado(this.ActualizarHora);
                this.Invoke(d);
            }
            else
            {
                this.lnlReloj.Text = DateTime.Now.ToString();
                
            }
        }
        public void ActualizarHora2(Object obj,string s)
        {
            if (this.lnlReloj.InvokeRequired)
            {
                delegado2 d2 = new delegado2(this.ActualizarHora2);
                object[] objs = new object[] { obj, s };
                this.BeginInvoke(d2,objs);
            }
            else
            {
                this.lblInt.Text = obj.ToString();
                this.lblString.Text = s;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ThreadStart delegado1 = new ThreadStart(this.ModificaReloj);
            this.hilo1 = new Thread(delegado1);
            this.hilo2 = new Thread(new ParameterizedThreadStart(this.ModificaReloj2));
            hilo1.Start();
            hilo2.Start(65);
            //this.ActualizarHora();
        }
        public void ModificaReloj()
        {
            do
            {
                this.ActualizarHora();
                Thread.Sleep(200);
            } while (true);
        }

        public void ModificaReloj2(Object obj)
        {

            do
            {
                string s;
                if ((int)obj < 90)
                {
                    obj = (int)obj + 1;
                    char c = (char)((int)obj);
                    s = c.ToString(); 
                }
                else
                {
                    obj = 64;
                    s = "";
                }

                this.ActualizarHora2(obj,s);
                Thread.Sleep(200);
            } while (true);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo1.IsAlive)
            {
                hilo1.Abort();
            }
            if (this.hilo2.IsAlive)
            {
                hilo2.Abort();
            }
        }
    }
}
