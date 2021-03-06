﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TP1Ventas;
using TP1VentasDTOs;

namespace TP1VentasDatos
{
    public class VentasDAO
    {
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
            return Funciones.DataTable_a_DTO<VentasDTO>(dt);
        }
        public static List<VentasDTO> ObtenerConCliente(int Idcliente)
        {
            string query = $"SELECT Ventas.Id,Ventas.Fecha,Clientes.Nombre as Cliente,Vehiculos.Modelo as Vehiculo,Vendedores.Nombre + ' ' + Vendedores.Apellido as Vendedor, Ventas.Observaciones,Ventas.Total " +
                $"FROM VENTAS " +
                $"LEFT JOIN Clientes ON Ventas.IdCliente = Clientes.Id " +
                $"LEFT JOIN Vehiculos ON Ventas.IdVehiculo = Vehiculos.Id " +
                $"LEFT JOIN Vendedores ON Ventas.IdVendedor = Vendedores.Id WHERE Clientes.Id = {Idcliente}";

            DataTable dt = SQLHelper.ObtenerDataTable(query);
            return Funciones.DataTable_a_DTO<VentasDTO>(dt);
        }
        public static string ExecTransaction(int IdVehiculo, int IdCliente, int IdVendedor, List<AccesoriosDTO> dtosAccesorios, string obs, decimal tot)
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

                            int IdVentas = SQLHelper.ObtenerProximoId("Ventas");
                            int IdVentasAccesorios = SQLHelper.ObtenerProximoId("VentasAccesorios");

                            //Query venta vehiculo
                            cmd.CommandText = $@"INSERT INTO Ventas (id,Fecha,IdVehiculo,IdCliente,IdVendedor,Observaciones,Total) VALUES ('{IdVentas}','{DateTime.Now:yyyy-MM-dd}','{IdVehiculo}','{IdCliente}','{IdVendedor}','{obs}','{tot.ToString(System.Globalization.CultureInfo.InvariantCulture)}')";

                            cmd.ExecuteNonQuery();

                            //Genera y ejecuta un query por cada accesorio seleccionado
                            foreach (AccesoriosDTO dto in dtosAccesorios)
                            {
                                int idaccesorio = dto.Id;
                                string precioventa = dto.PrecioVenta.ToString(System.Globalization.CultureInfo.InvariantCulture);

                                cmd.CommandText = $@"INSERT INTO VentasAccesorios (id,idVenta,idAccesorio,Cantidad,PrecioVenta) VALUES ('{IdVentasAccesorios}','{IdVentas}','{idaccesorio}','1','{precioventa}')";

                                cmd.ExecuteNonQuery();

                                IdVentasAccesorios++;
                            }
                            //Resta 1 al stock del vehiculo
                            DataTable dt = SQLHelper.ObtenerDataTable($"select StockDisponible from Vehiculos where id = '{IdVehiculo}'");
                            int stock = (int)dt.Rows[0]["StockDisponible"] - 1;
                            cmd.CommandText = $"UPDATE Vehiculos SET StockDisponible = {stock} WHERE id = {IdVehiculo}";
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
