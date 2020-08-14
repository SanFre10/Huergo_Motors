using System.Collections.Generic;
using System.Data;
using TP1Ventas;
using TP1VentasDTOs;

namespace TP1VentasDatos
{
    public class VendedoresDAO
    {
        public static List<VendedoresDTO> GetVendedores(string filtro)
        {

                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vendedores WHERE Nombre LIKE '%{filtro}%' OR Apellido LIKE '%{filtro}%' OR Sucursal LIKE '%{filtro}%'");
            return Funciones.DataTable_a_DTO<VendedoresDTO>(dt);

        }

        public VendedoresDTO IniciarSesion(string usuario, string contraseña)
        {
            DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vendedores WHERE Usuario = '{usuario}' AND Contraseña = '{contraseña}'");

            if (dt.Rows.Count > 0)
            {
                VendedoresDTO dto = new VendedoresDTO
                {
                    Id = (int)dt.Rows[0]["Id"],
                    Nombre = (string)dt.Rows[0]["Nombre"],
                    Apellido = (string)dt.Rows[0]["Apellido"],
                    Sucursal = (string)dt.Rows[0]["Sucursal"],
                    Usuario = (string)dt.Rows[0]["Usuario"],
                    Contraseña = (string)dt.Rows[0]["Contraseña"]
                };

                return dto;
            }
            else
            {
                return null;
            }
        }
    }
}
