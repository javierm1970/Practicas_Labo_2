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

namespace Ejercicio_60_Sql
{
    public partial class Form1 : Form
    {
        string auxLegajo;
        string auxNombre;
        string auxApellido;
        string auxCurso;
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader objetoQueReciboInfo;

        public Form1()
        {
            miConexion = new SqlConnection();
            miConexion.ConnectionString = "Data Source = localhost; Database = utnfra; Trusted_Connection=True;";

            miComando = new SqlCommand();

            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "Select * From Alumnos";

                miConexion.Open();


                objetoQueReciboInfo = miComando.ExecuteReader();


                while (objetoQueReciboInfo.Read())
                {
                    auxLegajo = objetoQueReciboInfo["legajo"].ToString();
                    auxNombre = objetoQueReciboInfo["nombre"].ToString();
                    auxApellido = objetoQueReciboInfo["apellido"].ToString();
                    auxCurso = objetoQueReciboInfo["curso"].ToString();

                    richTextBox1.Text += string.Format("\n{0,20} {1,-50} {2,50} {3,-5}",
                        auxLegajo, auxNombre, auxApellido,auxCurso);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                miConexion.Close();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
