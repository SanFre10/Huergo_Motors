using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        //Login//
        [WebMethod]
        public ClientesDTO IniciarSesion(string usuario, string contraseña)
        {
            ClientesDTO dto = ClientesDAO.IniciarSesion(usuario, contraseña);
            if (dto != null){
                return dto;
            }
            return null;
        }

        //Registro//
        [WebMethod]
        public ClientesDTO RegistrarUsuario(ClientesDTO dto)
        {
            DAOBase<ClientesDTO>.Insert(dto);

            return dto;
        }

        //Busqueda de Vehiculos//
        [WebMethod]
        public List<VehiculosDTO> GetVehiculos()
        {
            return DAOBase<VehiculosDTO>.ReadAll();
        }
        [WebMethod]
        public List<VehiculosDTO> GetVehiculosFiltrados(string filtro, string valor)
        {
            List<VehiculosDTO> dto = VehiculosDAO.GetVehiculosConFiltro(filtro, valor);
            return dto;
        }

        //Detalle del Vehiculo//
        [WebMethod]
        public VehiculosDTO GetVehiculosbyId(int Id)
        {
            VehiculosDTO dto = DAOBase<VehiculosDTO>.Read(Id);
            return dto;
        }
        [WebMethod]
        public List<AccesoriosDTO> GetAccesoriosByModelo(string filtro)
        {
            return AccesoriosDAO.GetAccesoriosByModelo(filtro);
        }
        [WebMethod]
        public string GetImagenes(int idVehiculo)
        {

            return "data:image/png;base64," + Convert.ToBase64String(VehiculosDAO.GetImagenes(idVehiculo));

        }

        //Carrito//
        [WebMethod]
        public string CrearVenta(int IdVehiculo, int IdCliente, int IdVendedor, List<AccesoriosDTO> dtosAccesorios, string obs, decimal tot, int stock)
        {
            return VentasDAO.ExecTransaction(IdVehiculo, IdCliente, IdVendedor, dtosAccesorios, obs, tot, stock);
        }

        //Mis Compras//
        [WebMethod]
        public List<VentasDTO> GetVentas(int IdCliente)
        {
            return VentasDAO.ObtenerConCliente(IdCliente);
        }

        //Mis Datos//
        [WebMethod]
        public ClientesDTO ActualizarUsuario()
        {
            ClientesDTO dtot = new ClientesDTO
            {
                Id = 20,
                Direccion = "hola 123",
                Email = "Test@test.com",
                Nombre = "John Doe",
                Telefono = "12345678"
            };

            return DAOBase<ClientesDTO>.Update(dtot);
        }
        [WebMethod]
        public ClientesDTO GetDatosCliente(string cliente)
        {
            ClientesDTO dtot = new ClientesDTO
            {
                Id = 20,
                Direccion = "hola 123",
                Email = "Test@test.com",
                Nombre = "John Doe",
                Telefono = "12345678"
            };

            return dtot;
        }

        //
        [WebMethod]
        public List<ClientesDTO> GetClientes()
        {
            return DAOBase<ClientesDTO>.ReadAll();
        }
        [WebMethod]
        public List<AccesoriosDTO> GetAccesorios()
        {
            return DAOBase<AccesoriosDTO>.ReadAll();
        }



    }
}
