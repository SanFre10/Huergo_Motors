using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TP1Ventas
{
    public static class SQLHelper
    {
        public static readonly string ConnectionString = @"Data Source=SQL5049.site4now.net;Initial Catalog=DB_9CF8B6_HuergoMotorsVentas;User Id=DB_9CF8B6_HuergoMotorsVentas_admin;Password=huergo2020;";

        /// <summary>
        /// Permite obtener un DataTable en base al Query SQL proporcionado.
        /// </summary>
        /// <param name="selectQuery">SELECT query a ejecutar.</param>
        /// <returns></returns>
        public static DataTable ObtenerDataTable(string selectQuery)
        {
            DataTable dt = new DataTable("dt");

            using (SqlDataAdapter da = new SqlDataAdapter(selectQuery, ConnectionString))
            {
                da.Fill(dt);
            }

            return dt;
        }

        /// <summary>
        /// Permite ejecutar un INSERT, UPDATE o DELETE en la Base de Datos.
        /// </summary>
        /// <param name="commandText">Comando a ejecutar.</param>
        public static int EjecutarComando(string commandText)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = commandText;
                    int affectedRows = cmd.ExecuteNonQuery();
                    return affectedRows;
                }
            }
        }

        /// <summary>
        /// Permite obtener el próximo Id de una Tabla.
        /// </summary>
        /// <param name="tabla">Nombre de la tabla.</param>
        /// <returns></returns>
        public static int ObtenerProximoId(string tabla)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT IsNull(MAX(Id), 0) + 1 AS NextId FROM " + tabla;
                    int nextId = Convert.ToInt32(cmd.ExecuteScalar());
                    return nextId;
                }
            }
        }
    }
}
