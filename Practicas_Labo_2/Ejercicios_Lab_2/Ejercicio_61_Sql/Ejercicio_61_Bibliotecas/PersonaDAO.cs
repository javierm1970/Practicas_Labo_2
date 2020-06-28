using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;

namespace Ejercicio_61_Bibliotecas
{
    public class PersonaDAO
    {
        private SqlConnection miConexion;
        private SqlCommand miComando;
        private SqlDataReader miQuery;
        private DataTable miTabla = new DataTable();
        public PersonaDAO()
        {
            miConexion = new SqlConnection();
            miConexion.ConnectionString =
                "Data Source = localhost; DataBase = Persona; Trusted_Connection=True;";

            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
        }
        public void Guardar(string nombre, string apellido)
        {
            miComando.CommandText = "INSERT INTO dbo.Personas (Nombre,Apellido)" +
                " VALUES('" + nombre + "','" + apellido + "')";
            
            miConexion.Open();

            miComando.ExecuteNonQuery();
            miConexion.Close();
        }
        public SqlDataReader Leer()
        {
            miComando.CommandText = "Select [ID],[Nombre],[Apellido] From dbo.Personas" +
                " ORDER BY ID";
            
            
            //Con Parametros
            //miComando.CommandText = "Select * From Alumnos WHERE curso = @cursoAFiltrar";
            //miComando.Parameters.Clear();
            //miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", 1));
            //

            miConexion.Open();

            miQuery = miComando.ExecuteReader();

            return miQuery;
        }
        public SqlDataReader LeerPorID(string id)
        {
            miComando.CommandText = "Select [ID],[Nombre],[Apellido] From dbo.Personas" +
                " WHERE ID = '" + id + "'";

            //Con Parametros
            //miComando.CommandText = "Select * From Alumnos WHERE curso = @cursoAFiltrar";
            //miComando.Parameters.Clear();
            //miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", 1));
            //

            miConexion.Open();

            miQuery = miComando.ExecuteReader();

            return miQuery;
        }
        public void Modificar(string dni,string nom, string ape)
        {
            miComando.CommandText = "UPDATE dbo.Personas SET " +
                "Nombre ='" + nom + "'" +
                ",Apellido ='" + ape + "'" +
                " WHERE ID = '" + dni + "'";

            miConexion.Open();

            miComando.ExecuteNonQuery();
            miConexion.Close();
        }
        public void Borrar(string id)
        {
            miComando.CommandText = "DELETE FROM dbo.Personas WHERE ID = '" + id + "'";

            miConexion.Open();

            miComando.ExecuteNonQuery();
            miConexion.Close();
        }
    }
}
