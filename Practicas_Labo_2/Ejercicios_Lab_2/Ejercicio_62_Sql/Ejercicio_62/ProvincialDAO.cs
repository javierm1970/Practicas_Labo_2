using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Ejercicio_62
{
    public class ProvincialDAO
    {
        private int id;
        private int duracion;
        private string origen;
        private string destino;
        private float costo;
        private short tipo;

        private SqlConnection miConexion;
        private SqlCommand miComando;
        private SqlDataReader miQuery;
        private DataTable miTabla = new DataTable();

        public ProvincialDAO()
        {
            miConexion = new SqlConnection();
            miConexion.ConnectionString =
                "Data Source = localhost; DataBase = Centralita; Trusted_Connection=True;";

            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
        }
        public ProvincialDAO(int id, int duracion, string origen, string destino, float costo)
            :this()
        {
            this.id = id;
            this.duracion = duracion;
            this.origen = origen;
            this.destino = destino;
            this.costo = costo;
            this.tipo = 1;
        }
        public void Guardar()
        {
            miComando.CommandText = @"INSERT INTO dbo.Llamadas (Duracion,Origen,Destino,Costo,Tipo)" +
                                    " VALUES( "+ this.duracion + "," +
                                    "'" + this.origen + "'," +
                                    "'" + this.destino + "'," +
                                    this.costo + "," + this.tipo +")";

            miConexion.Open();

            miComando.ExecuteNonQuery();
            miConexion.Close();

        }
        public ProvincialDAO Leer(string idLlamada)
        {
            ProvincialDAO auxLlamada = new ProvincialDAO();
            miComando.CommandText = @"Select ID,Duracion,Origen,Destino,Costo,Tipo" +
                                    " FROM dbo.Llamadas" +
                                    " WHERE ID = " + idLlamada +"";
            //Con Parametros
            //miComando.CommandText = "Select * From Alumnos WHERE curso = @cursoAFiltrar";
            //miComando.Parameters.Clear();
            //miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", 1));
            //
            miConexion.Open();
            miQuery = miComando.ExecuteReader();
            miQuery.Read();

            auxLlamada.id = (int)miQuery[0];
            auxLlamada.duracion = (int)miQuery[1];
            auxLlamada.origen = miQuery[2].ToString();
            auxLlamada.destino = miQuery[3].ToString();
            
            string auxCosto=miQuery[4].ToString();
            if ((bool)miQuery[5])
            {
                auxLlamada.tipo = 1;
            }
            else
            {
                auxLlamada.tipo = 0;
            }
            
            float.TryParse(auxCosto, out auxLlamada.costo);
            

            return auxLlamada;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}",
                this.id,this.duracion,this.origen,this.destino,this.costo,this.tipo);
        }
    }
}
