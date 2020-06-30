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
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    //[System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public List<AccesoriosDTO> GetAccesoriosByModelo(string filtro)
        {
            return AccesoriosDAO.GetAccesoriosByModelo(filtro);
        }
        [WebMethod]
        public List<AccesoriosDTO> GetAccesorios()
        {
            return AccesoriosDAO.GetAllAccesorios();
        }
        [WebMethod]
        public List<ClientesDTO> GetClientes()
        {
            return ClientesDAO.GetAllClientes();
        }
        [WebMethod]
        public List<VehiculosDTO> GetVehiculos()
        {
            return VehiculosDAO.GetAllVehiculos();
        }
        [WebMethod]
        public List<VentasDTO> GetVentas(int IdCliente)
        {
            return VentasDAO.ObtenerConCliente(IdCliente);
        }
        [WebMethod]
        public string CrearVenta(int IdVehiculo, int IdCliente, int IdVendedor, List<AccesoriosDTO> dtosAccesorios, string obs, decimal tot, int stock)
        {
            return VentasDAO.ExecTransaction(IdVehiculo, IdCliente, IdVendedor, dtosAccesorios, obs, tot, stock);
        }


    }
}
