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
                return Funciones.Vendedores_DataTable_a_DTO(dt);

        }
        public static List<string> GetNameVendedores(List<VendedoresDTO> dtolist) 
        {

                List<string> ret = new List<string>(); 
                foreach (VendedoresDTO dto in dtolist)
                {
                    ret.Add(dto.Nombre + " " + dto.Apellido); 
                }
                return ret;
	    

        }
        public static List<VendedoresDTO> GetVendedoresById(int Id)
        {

                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vendedores WHERE Id = '{Id}'");
                return Funciones.Vendedores_DataTable_a_DTO(dt);
 
        }
        public static int AgregarVendedores(string query)
        {
          

                return SQLHelper.EjecutarComando(query);
            

        }
        public static int AgregarVendedoresPorDTO(VendedoresDTO dto)
        {


            int id = SQLHelper.ObtenerProximoId("Vendedores");
            return SQLHelper.EjecutarComando($"INSERT INTO Vendedores(Id, Nombre, Apellido, Sucursal,Usuario,Contraseña) VALUES ('{id}','{dto.Nombre}','{dto.Apellido}','{dto.Sucursal}','{dto.Usuario}','{dto.Contraseña}')");



        }
        public static int ModificarVendedores(string query)
        {

                return SQLHelper.EjecutarComando(query);

        }
        public static int ModificarVendedoresPorDTO(VendedoresDTO dto)
        {

            return SQLHelper.EjecutarComando($"UPDATE Vendedores SET Nombre='{dto.Nombre}', Apellido='{dto.Apellido}', Sucursal='{dto.Sucursal}',Usuario = '{dto.Usuario}',Contraseña='{dto.Contraseña}' WHERE Id='{dto.Id}'");

        }
        public static int EliminarVendedores(int Id)
        {

                return SQLHelper.EjecutarComando($"DELETE from vendedores WHERE Id = {Id}");

        }
        public static int ObtenerProximoId()
        {


                return SQLHelper.ObtenerProximoId("vendedores");

        }
        public VendedoresDTO IniciarSesion(string usuario, string contraseña)
        {
            DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Vendedores WHERE Usuario = '{usuario}' AND Contraseña = '{contraseña}'");

            if (dt.Rows.Count > 0)
            {
                VendedoresDTO dto = new VendedoresDTO();

                dto.Id = (int)dt.Rows[0]["Id"];
                dto.Nombre = (string)dt.Rows[0]["Nombre"];
                dto.Apellido = (string)dt.Rows[0]["Apellido"];
                dto.Sucursal = (string)dt.Rows[0]["Sucursal"];
                dto.Usuario = (string)dt.Rows[0]["Usuario"];
                dto.Contraseña = (string)dt.Rows[0]["Contraseña"];

                return dto;
            }
            else
            {
                return null;
            }
        }
    }
}
