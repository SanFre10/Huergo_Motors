using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Services;
using TP1VentasDatos;
using TP1VentasDTOs;
using TP1VentasNegocio;

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
        public List<AutoConFoto> GetVehiculos()
        {
            List<VehiculosDTO> vehiculos = VehiculosDAO.GetVehiculos();
            List<AutoConFoto> final = new List<AutoConFoto>();
            foreach (VehiculosDTO v in vehiculos)
            {
                List<VehiculosImagenesDTO> imagenes = VehiculosDAO.GetImagenes(v.Id);
                AutoConFoto auto = new AutoConFoto
                {
                    Vehiculo = v,
                    Fotos = imagenes
                };

                final.Add(auto);
            }
            return final;

        }
        [WebMethod]
        public List<AutoConFoto> GetVehiculosFiltrados(string filtro, string valor)
        {
            List<VehiculosDTO> vehiculos = VehiculosDAO.GetVehiculos(filtro, valor);
            List<AutoConFoto> final = new List<AutoConFoto>();
            foreach (VehiculosDTO v in vehiculos)
            {
                List<VehiculosImagenesDTO> imagenes = VehiculosDAO.GetImagenes(v.Id);
                AutoConFoto auto = new AutoConFoto
                {
                    Vehiculo = v,
                    Fotos = imagenes
                };

                final.Add(auto);
            }
            return final;
        }

        //Detalle del Vehiculo//
        [WebMethod]
        public AutoConFoto GetVehiculosbyId(int Id)
        {
            VehiculosDTO dto = DAOBase<VehiculosDTO>.Read(Id);
            List<VehiculosImagenesDTO> imagenes = VehiculosDAO.GetImagenes(dto.Id);
            
            AutoConFoto auto = new AutoConFoto
            {
                Vehiculo = dto,
                Fotos = imagenes
            };
            return auto;

        }
        [WebMethod]
        public List<AccesoriosDTO> GetAccesoriosByModelo(string filtro)
        {
            return AccesoriosDAO.GetAccesoriosByModelo(filtro);
        }
        //[WebMethod]
        //public string GetImagenes(int idVehiculo)
        //{
        //    byte[] imagen = VehiculosDAO.GetImagenes(idVehiculo);
        //    if(imagen != null)
        //    {
        //        return "data:image/png;base64," + Convert.ToBase64String(imagen);
        //    }
        //    return "car-icon.png";
            

        //}

        //Carrito//
        [WebMethod]
        public string CrearVenta(int IdVehiculo, int IdCliente, int IdVendedor, List<AccesoriosDTO> dtosAccesorios, string obs, decimal tot)
        {
            return VentasDAO.ExecTransaction(IdVehiculo, IdCliente, IdVendedor, dtosAccesorios, obs, tot);
        }

        //Mis Compras//
        [WebMethod]
        public List<VentasDTO> GetVentas(int IdCliente)
        {
            return VentasDAO.ObtenerConCliente(IdCliente);
        }

        //Mis Datos//
        [WebMethod]
        public ClientesDTO ActualizarUsuario(ClientesDTO cliente)
        {
            return DAOBase<ClientesDTO>.Update(cliente);
        }
        //[WebMethod]
        //public ClientesDTO GetDatosCliente(string cliente)
        //{
        //    ClientesDTO dtot = new ClientesDTO
        //    {
        //        Id = 20,
        //        Direccion = "hola 123",
        //        Email = "Test@test.com",
        //        Nombre = "John Doe",
        //        Telefono = "12345678"
        //    };

        //    return dtot;
        //}

        //
        [WebMethod]
        public List<ClientesDTO> GetClientes()
        {
            return DAOBase<ClientesDTO>.ReadAll();
        }
        [WebMethod]
        public List<AccesoriosDTO> GetAccesoriosByIds(int[] Ids)
        {
            string texto = "(";
            foreach (int id in Ids)
            {
                texto += $"{id},";
            }
            texto = texto.Remove(texto.Length - 1);
            texto += ")";
            return AccesoriosDAO.GetAccesoriosbyIds(texto);
        }
        [WebMethod]
        public CarritoDTO carrito()
        {
            return new CarritoDTO();
        }

    }
}
