using _4_TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using TP1Ventas;
using TP1VentasDatos;

namespace TP1VentasDatos
{
    public class DAOBase<T> where T : DTOBase, new()
    {
        public static int ObtenerProximoId()
        {
            try
            {
                T tipo = new T();
                string tabla = tipo.GetType().GetProperties()[0].Name;
                return SQLHelper.ObtenerProximoId(tabla);
            }
            catch (Exception)
            {

                throw;
            }

        } 
        public static int Delete(int id)
        {
            try
            {
                T tipo = new T();
                string tabla = tipo.GetType().GetProperties()[0].Name;
                return SQLHelper.EjecutarComando($"Delete from [{tabla}] Where id = '{id}'");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static List<T> ReadAll()
        {
            try
            {
                List<T> lista = new List<T>();
                T tipo = new T();
                //El nombre de la tabla lo obtengo en base al nombre de la primera propiedad del DTO
                string tabla = tipo.GetType().GetProperties()[0].Name;

                DataTable dt;
                if (tabla != "Ventas")
                {
                    dt = SQLHelper.ObtenerDataTable($"SELECT * FROM [{tabla}]");
                }
                else
                {
                    dt = SQLHelper.ObtenerDataTable($"SELECT Ventas.Id,Ventas.Fecha,Clientes.Nombre as Cliente,Vehiculos.Modelo as Vehiculo,Vendedores.Nombre + ' ' + Vendedores.Apellido as Vendedor, Ventas.Observaciones,Ventas.Total FROM VENTAS LEFT JOIN Clientes ON Ventas.IdCliente = Clientes.Id " +
                        $"LEFT JOIN Vehiculos ON Ventas.IdVehiculo = Vehiculos.Id " +
                        $"LEFT JOIN Vendedores ON Ventas.IdVendedor = Vendedores.Id");
                }

                if (dt.Rows.Count > 0)
                {
                    lista = Funciones.DataTable_a_DTO<T>(dt);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static T Read(int id)
        {
            try
            {
                T obj = new T();
                string tabla = obj.GetType().GetProperties()[0].Name;

                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM [{tabla}] WHERE Id = '{id}'");
                if (dt.Rows.Count > 0)
                {
                    obj = Funciones.DataTable_a_DTO<T>(dt)[0];
                }

                return obj;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static T Update(T objetoDto)
        {
            try
            {
                //El nombre de la tabla lo obtengo en base al nombre de la primera propiedad del DTO
                string tabla = objetoDto.GetType().GetProperties()[0].Name;

                using (SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        PropertyInfo[] props =
                            objetoDto.GetType().GetProperties(
                                System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

                        List<string> campos = new List<string>();
                        List<string> parametros = new List<string>();

                        foreach (PropertyInfo propiedad in props)
                        {
                            if (props.First() != propiedad)
                            {
                                campos.Add(propiedad.Name);
                                parametros.Add("@" + propiedad.Name);

                                object valor;
                                valor = propiedad.GetValue(objetoDto, null);

                                //Si el valor es "null", le asigno un DBNull para que SQL lo entienda.
                                if (valor == null)
                                {
                                    valor = DBNull.Value;
                                }

                                cmd.Parameters.AddWithValue("@" + propiedad.Name, valor);
                            }
                        }



                        string query = $"UPDATE [{tabla}] SET ";

                        for (int i = 0; i < campos.Count; i++)
                        {
                            query += $"{campos[i]} = {parametros[i]}, ";
                        }
                        query = query.Remove(query.LastIndexOf(','), 1);

                        query += $" WHERE id = '{objetoDto.Id}'";

                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        int affectedRows = cmd.ExecuteNonQuery();
                    }
                }
                return objetoDto;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        //Al declarar la variable de tipo "T" en la clase genérica, ya no necesitamos hacerlo en cada uno de sus métodos.
        //public void Insert<T>(T objetoDto) where T : DTOBase, new()
        public static void Insert(T objetoDto)
        {
            try
            {
                //El nombre de la tabla lo obtengo en base al nombre de la primera propiedad del DTO
                string tabla = objetoDto.GetType().GetProperties()[0].Name;

                using (SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        objetoDto.Id = SQLHelper.ObtenerProximoId(tabla);

                        PropertyInfo[] props =
                            objetoDto.GetType().GetProperties(
                                System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

                        string campos = string.Empty;
                        string parametros = string.Empty;

                        foreach (PropertyInfo propiedad in props)
                        {
                            if (props.First() != propiedad)
                            {


                                campos += propiedad.Name + ',';
                                parametros += "@" + propiedad.Name + ',';

                                object valor;
                                valor = propiedad.GetValue(objetoDto, null);

                                //Si el valor es "null", le asigno un DBNull para que SQL lo entienda.
                                if (valor == null)
                                {
                                    valor = DBNull.Value;
                                }

                                cmd.Parameters.AddWithValue("@" + propiedad.Name, valor);
                            }
                        }



                        campos = campos.TrimEnd(',');
                        parametros = parametros.TrimEnd(',');

                        string query = $"INSERT INTO [{tabla}] ({campos}) VALUES ({parametros})";

                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        int affectedRows = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
