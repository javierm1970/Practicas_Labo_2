using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_68_Eventos_Biblioteca;

namespace Ejercicio_68_Eventos_Form
{
    public partial class FrmPersona : Form
    {
        private Persona persona;
        
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string msg;
            if (this.persona is null)
            {
                persona = new Persona();
                persona.eventoString += NotificarCambio; 
                persona.Apellido = textBoxApellido.Text;
                persona.Nombre = textBoxNombre.Text;
                this.btnCrear.Text = "Actualizar";
            }
            else
            {
                persona.Apellido = textBoxApellido.Text;
                persona.Nombre = textBoxNombre.Text;
            }
        }
        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }
    }
}
