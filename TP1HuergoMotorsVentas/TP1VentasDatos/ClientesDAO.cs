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
                return Funciones.Clientes_DataTable_a_DTO(dt);

        }
        public static List<string> GetNameClientes(List<ClientesDTO> dtolist)
        {

                List<string> ret = new List<string>();
                foreach (ClientesDTO dto in dtolist)
                {
                    ret.Add(dto.Nombre);
                }
                return ret;

        }

        public static List<ClientesDTO> GetClientesById(int Id)
        {


                DataTable dt = SQLHelper.ObtenerDataTable($"SELECT * FROM Clientes WHERE Id = '{Id}'");
                return Funciones.Clientes_DataTable_a_DTO(dt);

        }
        public static int AgregarClientes(string query)
        {

                return SQLHelper.EjecutarComando(query);
            

        }
        public static int AgregarClientesPorDTO(ClientesDTO dto)
        {
            int id = SQLHelper.ObtenerProximoId("Clientes");
            return SQLHelper.EjecutarComando($"INSERT INTO Clientes(Id, Nombre, Direccion, Telefono, Email) VALUES ('{id}','{dto.Nombre}','{dto.Direccion}','{dto.Telefono}', '{dto.Email}')");


        }
        public static int ModificarClientes(string query)
        {

                return SQLHelper.EjecutarComando(query);

        }
        public static int ModificarClientesPorDTO(ClientesDTO dto)
        {

            return SQLHelper.EjecutarComando($"UPDATE Clientes SET Nombre='{dto.Nombre}', Direccion='{dto.Direccion}', Telefono='{dto.Telefono}', Email='{dto.Email}' WHERE Id='{dto.Id}'");

        }
        public static int EliminarClientes(int Id)
        {

                return SQLHelper.EjecutarComando($"DELETE from clientes WHERE Id = {Id}");

            
        }
        public static int ObtenerProximoId()
        {

                return SQLHelper.ObtenerProximoId("clientes");

        }
    }
}
