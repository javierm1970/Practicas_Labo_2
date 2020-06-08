﻿using System;
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


namespace Ejercicio_61_Sql
{
    
    public partial class Form1 : Form
    {
        string auxLegajo;
        string auxNombre;
        string auxApellido;
        string auxCurso;

        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader miQuery;
        DataTable miTabla = new DataTable();

        public Form1()
        {
            miConexion = new SqlConnection();
            miConexion.ConnectionString = "Data Source = localhost; DataBase = utnfra; Trusted_Connection=True;";
            
            miComando = new SqlCommand();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
                dataGridView1.ReadOnly = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            miTabla.Rows.Clear();

            try
            {
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "Select * From Alumnos WHERE curso = @cursoAFiltrar";

                miComando.Parameters.Clear();
                miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", 1));


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



        }
    }
}
