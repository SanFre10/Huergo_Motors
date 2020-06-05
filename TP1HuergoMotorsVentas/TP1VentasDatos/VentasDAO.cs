using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TP1Ventas;
using TP1VentasDTOs;

namespace TP1VentasDatos
{
    public class VentasDAO
    {
        public static int ObtenerProximoId()
        {

                return SQLHelper.ObtenerProximoId("ventas");

        }
        public static List<VentasDTO> GetVentas()
        {

                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT Ventas.Id,Ventas.Fecha,Clientes.Nombre as Cliente,Vehiculos.Modelo as Vehiculo,Vendedores.Nombre + ' ' + Vendedores.Apellido as Vendedor, Ventas.Observaciones,Ventas.Total FROM VENTAS LEFT JOIN Clientes ON Ventas.IdCliente = Clientes.Id " +
                    $"LEFT JOIN Vehiculos ON Ventas.IdVehiculo = Vehiculos.Id " +
                    $"LEFT JOIN Vendedores ON Ventas.IdVendedor = Vendedores.Id");
                return Funciones.Ventas_DataTable_a_DTO(dt);
            
        }
        public static List<VentasDTO> ObtenerConFiltro(string filtro, string elegido, string inicio, string fin)
        {
            string query = $"SELECT Ventas.Id,Ventas.Fecha,Clientes.Nombre as Cliente,Vehiculos.Modelo as Vehiculo,Vendedores.Nombre + ' ' + Vendedores.Apellido as Vendedor, Ventas.Observaciones,Ventas.Total FROM VENTAS LEFT JOIN Clientes ON Ventas.IdCliente = Clientes.Id " +
                    $"LEFT JOIN Vehiculos ON Ventas.IdVehiculo = Vehiculos.Id " +
                    $"LEFT JOIN Vendedores ON Ventas.IdVendedor = Vendedores.Id WHERE ";
            if (elegido == "Cliente")
            {
                query += $" Clientes.Nombre LIKE '%{filtro}%' ";
            }
            else if (elegido == "Vehiculo")
            {
                query += $" Vehiculos.Modelo LIKE '%{filtro}%' ";
            }
            else if (elegido == "Vendedor")
            {
                query += $" Vendedores.Nombre LIKE '%{filtro}%' OR Vendedores.Apellido LIKE '%{filtro}%'";
            }
            if(inicio != "" && fin != "")
            {
                query += $" OR Fecha between '{inicio:yyyy-MM-dd}' and '{fin:yyyy-MM-dd}'";
            }
            
            DataTable dt = SQLHelper.ObtenerDataTable(query);
            return Funciones.Ventas_DataTable_a_DTO(dt);
        }
        public static string ExecTransaction(List<int>IDs, List<AccesoriosDTO> dtosAccesorios,string obs,decimal tot,int stock)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString))
                {

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {

                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Transaction = transaction;
                            cmd.Connection = conn;


                            //Query venta vehiculo
                            cmd.CommandText = $@"INSERT INTO Ventas (id,Fecha,IdVehiculo,IdCliente,IdVendedor,Observaciones,Total) VALUES ('{IDs[0]}','{DateTime.Now:yyyy-MM-dd}','{IDs[1]}','{IDs[2]}','{IDs[3]}','{obs}','{tot.ToString(System.Globalization.CultureInfo.InvariantCulture)}')";

                            cmd.ExecuteNonQuery();

                            //Genera y ejecuta un query por cada accesorio seleccionado
                            foreach (AccesoriosDTO dto in dtosAccesorios)
                            {
                                int idaccesorio = dto.Id;
                                string precioventa = dto.PrecioVenta.ToString(System.Globalization.CultureInfo.InvariantCulture);

                                cmd.CommandText = $@"INSERT INTO VentasAccesorios (id,idVenta,idAccesorio,Cantidad,PrecioVenta) VALUES ('{IDs[4]}','{IDs[0]}','{idaccesorio}','1','{precioventa}')";

                                cmd.ExecuteNonQuery();

                                IDs[4]++;
                            }
                            //Resta 1 al stock del vehiculo

                            cmd.CommandText = $"UPDATE Vehiculos SET StockDisponible = {stock} WHERE id = {IDs[1]}";
                            cmd.ExecuteNonQuery();

                        }

                        transaction.Commit();
                        return "Transaccion realizada con éxito!";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
