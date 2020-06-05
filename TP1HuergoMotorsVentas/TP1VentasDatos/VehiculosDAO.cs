using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDTOs;
using TP1Ventas;
using System.Globalization;

namespace TP1VentasDatos
{
    public class VehiculosDAO
    {
        public static List<VehiculosDTO> GetVehiculos(string filtro)
        {

                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vehiculos WHERE Tipo LIKE '%{filtro}%' OR Modelo LIKE '%{filtro}%'");
                return Funciones.Vehiculos_DataTable_a_DTO(dt);

        }
        public static List<String> GetModelVehiculos(List<VehiculosDTO> dtolist)
        {

                List<string> ret = new List<string>();
                foreach (VehiculosDTO dto in dtolist)
                {
                    ret.Add(dto.Modelo);
                }
                return ret;


        }
        public static List<VehiculosDTO> GetVehiculosById(int id)
        {


                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vehiculos WHERE id = '{id}'");
                return Funciones.Vehiculos_DataTable_a_DTO(dt);

        }
        public static int AgregarVehiculos(string query)
        {

                return SQLHelper.EjecutarComando(query);

        }
        public static int AgregarVehiculosPorDTO(VehiculosDTO dto)
        {

            int id = SQLHelper.ObtenerProximoId("Vehiculos");
            return SQLHelper.EjecutarComando($"INSERT INTO Vehiculos(Id, Modelo, Tipo, PrecioVenta, StockDisponible) VALUES ('{id}','{dto.Modelo}','{dto.Tipo}','{dto.PrecioVenta.ToString(CultureInfo.InvariantCulture)}', '{dto.StockDisponible.ToString(CultureInfo.InvariantCulture)}')");


        }
        public static int ModificarVehiculos(string query)
        {

                return SQLHelper.EjecutarComando(query);

        }

        public static int ModificarVehiculosPorDTO(VehiculosDTO dto)
        {

            return SQLHelper.EjecutarComando($"UPDATE Vehiculos SET Modelo='{dto.Modelo}', Tipo='{dto.Tipo}', PrecioVenta='{dto.PrecioVenta.ToString(CultureInfo.InvariantCulture)}', StockDisponible='{dto.StockDisponible.ToString(CultureInfo.InvariantCulture)}' WHERE Id='{dto.Id}'");

        }
        public static int EliminarVehiculos(int id)
        {

                return SQLHelper.EjecutarComando($"DELETE from vehiculos WHERE id = {id}");

        }
        public static int ObtenerProximoId()
        {

                return SQLHelper.ObtenerProximoId("vehiculos");

        }

    }
}

