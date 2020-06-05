using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDatos;

namespace TP1VentasNegocio
{
    public class ClientesNegocio
    {
        public static List<ClientesDTO> MostrarClientes(string filtro)
        {
            return ClientesDAO.GetClientes(filtro);
        }
        public static List<string> MostrarNombreClientes(List<ClientesDTO> lstdto)
        {
            return ClientesDAO.GetNameClientes(lstdto);
        }

        public static List<ClientesDTO> MostrarClientesPorId(int Id)
        {
            return ClientesDAO.GetClientesById(Id);
        }
        public static void ModificarClientes(string query)
        {
            ClientesDAO.ModificarClientes(query);
        }
        public static void ModificarClientesPorDTO(ClientesDTO dto)
        {
            ClientesDAO.ModificarClientesPorDTO(dto);
        }
        public static void AgregarClientes(string query)
        {
            ClientesDAO.AgregarClientes(query);
        }
        public static void AgregarClientesPorDTO(ClientesDTO dto)
        {
            ClientesDAO.AgregarClientesPorDTO(dto);
        }
        public static void EliminarClientes(int Id)
        {
            ClientesDAO.EliminarClientes(Id);
        }
        public static int ProximoIdClientes()
        {
            return ClientesDAO.ObtenerProximoId();
        }
    }
}
