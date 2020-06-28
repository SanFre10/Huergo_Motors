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
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
    //FUNCIONES QUE FALTAN: GetAccesoriosByModelo. GetVentas(idcliente).
        [WebMethod]
        public static List<AccesoriosDTO> GetAccesorios(string filtro)
        {
            return AccesoriosDAO.GetAccesorios(filtro);
        }
        public static List<ClientesDTO> GetClientes(string filtro)
        {
            return ClientesDAO.GetClientes(filtro);
        }
        public static List<VehiculosDTO> GetVehiculos(string filtro)
        {
            return VehiculosDAO.GetVehiculos(filtro);
        }
        public static string CrearVenta(int IdVehiculo, int IdCliente, int IdVendedor, List<AccesoriosDTO> dtosAccesorios, string obs, decimal tot, int stock)
        {
            return VentasDAO.ExecTransaction(IdVehiculo, IdCliente, IdVendedor, dtosAccesorios, obs, tot, stock);
        }
        public static List<VentasDTO> GetVentas(string filtro, string elegido, string inicio, string fin)
        {
            return VentasDAO.ObtenerConFiltro(filtro, elegido, inicio, fin);
        }
        public static void RegistrarUsuario(ClientesDTO dto)
        {
            ClientesDAO.AgregarClientesPorDTO(dto);
        }
        /*public VendedoresDTO IniciarSesion(string usuario, string contraseña)
        {
            VendedoresDAO dao = new VendedoresDAO();
            return dao.IniciarSesion(usuario, contraseña);
        }*/
        public static void ActualizarUsuario(ClientesDTO dto)
        {
            ClientesDAO.ModificarClientesPorDTO(dto);
        }
    }
}
