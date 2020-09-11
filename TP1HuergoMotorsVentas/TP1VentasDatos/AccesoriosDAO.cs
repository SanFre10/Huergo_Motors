using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TP1Ventas;
using System.Globalization;

namespace TP1VentasDatos
{
    public class AccesoriosDAO
    {
        public static List<AccesoriosDTO> GetAccesorios(string filtro)
        {

                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Accesorios WHERE Nombre LIKE '%{filtro}%' OR Modelo LIKE '%{filtro}%'");
                return Funciones.DataTable_a_DTO<AccesoriosDTO>(dt);

        }
        public static List<AccesoriosDTO> GetAccesoriosByModelo(string filtro)
        {
            DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Accesorios WHERE Modelo LIKE '{filtro}'");
            return Funciones.DataTable_a_DTO<AccesoriosDTO>(dt);
        }
        public static List<AccesoriosDTO> BuscarPorNombre(List<string> nombres)
        {
            List<AccesoriosDTO> dtos = new List<AccesoriosDTO>();

            foreach (string nombre in nombres)
            {
                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Accesorios WHERE Nombre = '{nombre}'");
                List<AccesoriosDTO> acc = Funciones.DataTable_a_DTO<AccesoriosDTO>(dt);
                dtos.Add(acc[0]);
            }
            return dtos;
        }
        public static List<AccesoriosDTO> GetAccesoriosbyIds(string texto)
        {

            DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Accesorios WHERE id IN {texto}");
            return Funciones.DataTable_a_DTO<AccesoriosDTO>(dt);

        }

    }
}
