using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Ejercicio_61_Bibliotecas;


namespace Ejercicio_61_Sql
{
    
    public partial class FrmPersona : Form
    {
        SqlDataReader miQuery;
        public FrmPersona()
        {
            InitializeComponent();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            PersonaDAO miper = new PersonaDAO();
            miQuery = miper.Leer();
            string miLinea;
            this.listBoxPersonas.Items.Clear();
            while (miQuery.Read())
            {
                miLinea = string.Format("{0}  {1} {2}",
                    miQuery[0], miQuery[1], miQuery[2]);
                this.listBoxPersonas.Items.Add(miLinea);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PersonaDAO miper = new PersonaDAO();
            miper.Guardar(textBoxNombre.Text, textBoxApellido.Text);
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            btnLeer_Click(sender, e);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            PersonaDAO miper = new PersonaDAO();
            miper.Modificar(lblID.Text,textBoxNombre.Text, textBoxApellido.Text);
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            lblID.Text = "";
            btnLeer_Click(sender, e);
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            PersonaDAO miper = new PersonaDAO();
            miper.Borrar(lblID.Text);
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            lblID.Text = "";
            btnLeer_Click(sender, e);
        }
        private void listBoxPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonaDAO miper = new PersonaDAO();
            string aux_ID;
            int posicion;

            posicion = listBoxPersonas.SelectedItem.ToString().IndexOf(' ');
            aux_ID = listBoxPersonas.SelectedItem.ToString().Substring(0, posicion);
            miQuery = miper.LeerPorID(aux_ID);
            miQuery.Read();
            lblID.Text = miQuery[0].ToString();
            textBoxNombre.Text = miQuery[1].ToString();
            textBoxApellido.Text = miQuery[2].ToString();
        }
    }
}
