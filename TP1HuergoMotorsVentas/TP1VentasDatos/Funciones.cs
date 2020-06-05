using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1VentasDatos
{
    public class Funciones
    {
        public static List<VehiculosDTO> Vehiculos_DataTable_a_DTO(DataTable dt)
        {
            List<VehiculosDTO> vehiculos = new List<VehiculosDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                VehiculosDTO v = new VehiculosDTO();

                v.Id = (int)dr["Id"];
                v.Modelo = (string)dr["Modelo"];
                v.Tipo = (string)dr["Tipo"];
                v.PrecioVenta = (decimal)dr["PrecioVenta"];
                v.StockDisponible = (int)dr["StockDisponible"];

                vehiculos.Add(v);
            }
            return vehiculos;
        }
        public static List<VentasDTO> Ventas_DataTable_a_DTO(DataTable dt)
        {
            List<VentasDTO> ventas = new List<VentasDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                VentasDTO v = new VentasDTO();

                v.Id = (int)dr["Id"];
                v.Fecha = (DateTime)dr["Fecha"];
                v.Vehiculo = (string)dr["Vehiculo"];
                v.Cliente = (string)dr["CLiente"];
                v.Vendedor = (string)dr["Vendedor"];
                v.Observaciones = (string)dr["Observaciones"];
                v.Total = (decimal)dr["Total"];

                ventas.Add(v);

            }
            return ventas;
        }


        public static List<VendedoresDTO> Vendedores_DataTable_a_DTO(DataTable dt)
        {
            List<VendedoresDTO> vendedores = new List<VendedoresDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                VendedoresDTO v = new VendedoresDTO();

                v.Id = (int)dr["Id"];
                v.Nombre = (string)dr["Nombre"];
                v.Apellido = (string)dr["Apellido"];
                v.Sucursal = (string)dr["Sucursal"];
                v.Usuario = (string)dr["Usuario"];
                v.Contraseña = (string)dr["Contraseña"];

                vendedores.Add(v);
            }
            return vendedores;
        }

        public static List<AccesoriosDTO> Accesorios_DataTable_a_DTO(DataTable dt)
        {
            List<AccesoriosDTO> accesorios = new List<AccesoriosDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                AccesoriosDTO v = new AccesoriosDTO();

                v.Id = (int)dr["Id"];
                v.Nombre = (string)dr["Nombre"];
                v.Modelo = (string)dr["Modelo"];
                v.PrecioVenta = (decimal)dr["PrecioVenta"];

                accesorios.Add(v);
            }
            return accesorios;
        }

        public static List<ClientesDTO> Clientes_DataTable_a_DTO(DataTable dt)
        {
            List<ClientesDTO> clientes = new List<ClientesDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                ClientesDTO v = new ClientesDTO();

                v.Id = (int)dr["Id"];
                v.Nombre = (string)dr["Nombre"];
                v.Direccion = (string)dr["Direccion"];
                v.Telefono = (string)dr["Telefono"];
                v.Email = (string)dr["Email"];

                clientes.Add(v);
            }
            return clientes;
        }
    }
}
