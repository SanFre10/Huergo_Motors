using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TP1VentasDatos;
using TP1VentasDTOs;

namespace Services
{
    /// <summary>
    /// Descripción breve de ClientesWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ClientesWeb : System.Web.Services.WebService
    {

        [WebMethod]
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
