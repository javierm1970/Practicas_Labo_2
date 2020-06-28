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
    public partial class FrmProductos : Form
    {
        string auxId;
        string auxNombre;
        string auxNumero;
        string auxStock;
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader miQuery;
        DataTable miTabla;
        SqlConnection miConexion2;
        SqlCommand miComando2;
        SqlDataReader miQuery2;
        DataTable miTabla2;
        public FrmProductos()
        {
            miConexion = new SqlConnection();
            miConexion.ConnectionString = "Data Source = localhost; Database = AdventureWorks2017; Trusted_Connection=True;";
            miComando = new SqlCommand();
            miTabla = new DataTable();
            miConexion2 = new SqlConnection();
            miConexion2.ConnectionString = "Data Source = localhost; Database = AdventureWorks2017; Trusted_Connection=True;";
            miComando2 = new SqlCommand();
            miTabla2 = new DataTable();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //int ID;
            //if(int.TryParse(textBoxID.Text,out ID))
            //{

            //}
            //miComando.CommandText = 
            //    "Select * From Production.Product Where ProductID=" 
            //    ;
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            miTabla.Rows.Clear();

            try
            {
               
                string conexionString = @"Select ProductID, " +
                        "Name , " +
                        "ProductNumber , " +
                        "SafetyStockLevel  " +
                        "From Production.Product " +
                        "";


                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = conexionString;
                //miComando.CommandText = "Select * From Alumnos WHERE curso = @cursoAFiltrar";

                //miComando.Parameters.Clear();
                //miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", 1));

                miConexion.Open();


                miQuery = miComando.ExecuteReader();

                miTabla.Load(miQuery);

                dataGridView1.DataSource = miTabla;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                miConexion.Close();
            }
            //try
            //{
            //    miComando.Connection = miConexion;
            //    miComando.CommandType = CommandType.Text;
            //    miComando.CommandText = "Select * From Production.Product";
            //    miConexion.Open();
            //    objetoQueReciboInfo = miComando.ExecuteReader();

            //    while (objetoQueReciboInfo.Read())
            //    {
            //        auxLegajo = objetoQueReciboInfo["ProductID"].ToString();
            //        auxNombre = objetoQueReciboInfo["Name"].ToString();
            //        auxApellido = objetoQueReciboInfo["ProductNumber"].ToString();
            //        auxCurso = objetoQueReciboInfo["SafetyStockLevel"].ToString();

            //        richTextBox1.Text += string.Format("\n{0,10} {1,-50} {2,-25} {3,20}",
            //            auxLegajo, auxNombre, auxApellido, auxCurso);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    miConexion.Close();
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            auxId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            BuscarProducto(auxId);
        }
        public bool BuscarProducto(string id)
        {
            auxId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            miComando2.Parameters.Clear();
            miComando2.Parameters.Add(new SqlParameter("filtro_ID", auxId));

            string conexionString2 = @"Select ProductID [ID], " +
                                        "Name [Nombre], " +
                                        "ProductNumber [Numero], " +
                                        "SafetyStockLevel [Stock] " +
                                        "From Production.Product " +
                                        "Where ProductID = @filtro_ID";


            miComando2.Connection = miConexion2;
            miComando2.CommandType = CommandType.Text;
            miComando2.CommandText = conexionString2;
            miConexion2.Open();
            miQuery2 = miComando2.ExecuteReader();

            miQuery2.Read();
                     
            auxId = miQuery2[0].ToString();
            auxNombre = miQuery2[1].ToString();
            auxNumero = miQuery2[2].ToString();
            auxStock = miQuery2[3].ToString();

            textBoxID.Text = auxId;
            textBoxName.Text = auxNombre;
            textBoxNumber.Text = auxNumero;
            textBoxStock.Text = auxStock;
            
            miConexion2.Close();
            //miTabla.Load(miQuery);
            return true;
            
        }
    }
}
