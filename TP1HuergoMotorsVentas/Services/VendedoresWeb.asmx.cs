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
    /// Descripción breve de VendedoresWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class VendedoresWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public static List<VendedoresDTO> MostrarVendedores(string filtro)
        {
            return VendedoresDAO.GetVendedores(filtro);
        }
        public static List<string> MostrarNombreVendedores(List<VendedoresDTO> lstdto)
        {
            return VendedoresDAO.GetNameVendedores(lstdto);
        }

        public static List<VendedoresDTO> MostrarVendedoresPorId(int Id)
        {
            return VendedoresDAO.GetVendedoresById(Id);
        }
        public static void ModificarVendedores(string query)
        {
            VendedoresDAO.ModificarVendedores(query);
        }
        public static void ModificarVendedoresPorDTO(VendedoresDTO dto)
        {
            VendedoresDAO.ModificarVendedoresPorDTO(dto);
        }
        public static void AgregarVendedores(string query)
        {
            VendedoresDAO.AgregarVendedores(query);
        }
        public static void AgregarVendedoresPorDTO(VendedoresDTO dto)
        {
            VendedoresDAO.AgregarVendedoresPorDTO(dto);
        }
        public static void EliminarVendedores(int Id)
        {
            VendedoresDAO.EliminarVendedores(Id);
        }
        public static int ProximoIdVendedores()
        {
            int Id = VendedoresDAO.ObtenerProximoId();
            if (Id != 0)
            {
                return Id;
            }
            return 0;
        }
        public VendedoresDTO IniciarSesion(string usuario, string contraseña)
        {
            VendedoresDAO dao = new VendedoresDAO();
            return dao.IniciarSesion(usuario, contraseña);
        }
    }
}
