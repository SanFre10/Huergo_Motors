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
            return Funciones.DataTable_a_DTO<VehiculosDTO>(dt);

        }

        public static List<VehiculosDTO> GetVehiculosConFiltro(string filtro,string valor)
        {
            DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vehiculos WHERE {filtro} LIKE '{valor}'");
            return Funciones.DataTable_a_DTO<VehiculosDTO>(dt);
        }

        public static byte[] GetImagenes(int id)
        {
            DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM VehiculosImagenes WHERE IdVehiculo = '{id}'");
            if(dt.Rows.Count > 0)
            {
                return (byte[])dt.Rows[0]["Foto"];
            }
            return null;


        }


    }
}

