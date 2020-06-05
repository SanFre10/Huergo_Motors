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
                return Funciones.Accesorios_DataTable_a_DTO(dt);

        }
        public static List<string> GetNameAndValue(List<AccesoriosDTO> dtolist)
        {
                List<string> ret = new List<string>();
                foreach (AccesoriosDTO dto in dtolist)
                {
                    ret.Add(dto.Nombre + "-" + dto.PrecioVenta);
                }
                return ret;
        }
        public static List<AccesoriosDTO> BuscarPorNombre(List<string> nombres)
        {
            List<AccesoriosDTO> dtos = new List<AccesoriosDTO>();
            List<AccesoriosDTO> acc = new List<AccesoriosDTO>();

            foreach(string nombre in nombres)
            {
                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Accesorios WHERE Nombre = '{nombre}'");
                acc = Funciones.Accesorios_DataTable_a_DTO(dt);
                dtos.Add(acc[0]);
            }
            return dtos;
        }

        public static List<AccesoriosDTO> GetAccesoriosById(int id)
        { 

                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Accesorios WHERE id = '{id}'");
                return Funciones.Accesorios_DataTable_a_DTO(dt);

        }
        public static int AgregarAccesorios(string query)
        { 
                return SQLHelper.EjecutarComando(query);
        }
        public static int AgregarAccesoriosPorDTO(AccesoriosDTO dto)
        {
            int id = SQLHelper.ObtenerProximoId("Accesorios");
            return SQLHelper.EjecutarComando($"INSERT INTO Accesorios(Id, Nombre, Modelo, PrecioVenta) VALUES('{id}', '{dto.Nombre}', '{dto.Modelo}', '{dto.PrecioVenta.ToString(CultureInfo.InvariantCulture)}')");
        }
        public static int ModificarAccesorios(string query)
        {
            

                return SQLHelper.EjecutarComando(query);
   
        }
        public static int ModificarAccesoriosPorDTO(AccesoriosDTO dto)
        {


            return SQLHelper.EjecutarComando($"UPDATE Accesorios SET Nombre='{dto.Nombre}',Modelo='{dto.Modelo}',PrecioVenta='{dto.PrecioVenta.ToString(CultureInfo.InvariantCulture)}' WHERE ID = '{dto.Id}'");

        }
        public static int EliminarAccesorios(int id)
        { 

                return SQLHelper.EjecutarComando($"DELETE from accesorios WHERE id = {id}");
            

        }
        public static int ObtenerProximoId()
        {
            

                return SQLHelper.ObtenerProximoId("accesorios");

        }
    }
}
