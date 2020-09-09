using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDTOs;
using TP1Ventas;
using System.Globalization;
using TP1VentasNegocio;

namespace TP1VentasDatos
{
    public class VehiculosDAO
    {
        public static List<VehiculosDTO> GetVehiculos(string filtro)
        {

            DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vehiculos WHERE Tipo LIKE '%{filtro}%' OR Modelo LIKE '%{filtro}%'");
            return Funciones.DataTable_a_DTO<VehiculosDTO>(dt);

        }

        public static List<VehiculosDTO> GetVehiculos(string filtro = "",string valor = "")
        {
            DataTable dt;
            try
            {
                if (valor != "")
                {
                    if (filtro == "Precio desde")
                    {
                        dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vehiculos WHERE PrecioVenta > '{valor}'");
                    }
                    else if (filtro == "Precio hasta")
                    {
                        dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vehiculos WHERE PrecioVenta < '{valor}'");
                    }
                    else
                    {
                        dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vehiculos WHERE {filtro} LIKE '{valor}'");
                    }
                }
                else
                {
                    dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vehiculos");
                }

                return Funciones.DataTable_a_DTO<VehiculosDTO>(dt);
            }
            catch (Exception)
            {
                return new List<VehiculosDTO>();
            }
            


         
        }

        public static List<VehiculosImagenesDTO> GetImagenes(int id)
        {
            DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM VehiculosImagenes WHERE IdVehiculo = '{id}'");
            return Funciones.DataTable_a_DTO<VehiculosImagenesDTO>(dt);


        }


    }
}

