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
    public partial class FrmMostrar : Form
    {
        
        public FrmMostrar()
        {
            InitializeComponent();
        }
        public delegate void delegado(string nombre);
        public void ActualizarNombre(string nombre)
        {
            this.lblEtiqueta.Text = nombre;
        }
    }
}
