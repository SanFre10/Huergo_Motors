using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1Ventas;

namespace TP1VentasDatos
{
    public class ClientesDAO
    {
        public static List<ClientesDTO> GetClientes(string filtro)
        {

                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM clientes WHERE Nombre LIKE '%{filtro}%' OR Direccion LIKE '%{filtro}%' OR Telefono LIKE '%{filtro}%' OR Email LIKE '%{filtro}%' ");
                return Funciones.DataTable_a_DTO<ClientesDTO>(dt);

        }


        public static ClientesDTO IniciarSesion(string user,string pass)
        {
            try
            {
                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Clientes WHERE Usuario = '{user}' AND Contraseña = '{pass}'");

                if (dt.Rows.Count > 0)
                {
                    ClientesDTO dto = new ClientesDTO
                    {
                        Id = (int)dt.Rows[0]["Id"],
                        Nombre = (string)dt.Rows[0]["Nombre"],
                        Direccion = (string)dt.Rows[0]["Direccion"],
                        Telefono = (string)dt.Rows[0]["Telefono"],
                        Email = (string)dt.Rows[0]["Email"],
                        Usuario = (string)dt.Rows[0]["Usuario"]
                    };

                    return dto;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }


            
        }
    }
}
