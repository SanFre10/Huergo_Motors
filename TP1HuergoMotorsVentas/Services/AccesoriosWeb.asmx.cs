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
    /// Descripción breve de AccesoriosWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AccesoriosWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public static List<AccesoriosDTO> MostrarAccesorios(string filtro)
        {
            return AccesoriosDAO.GetAccesorios(filtro);
        }
        public static List<string> MostrarNombreYPrecioAccesorios(List<AccesoriosDTO> lstdto)
        {
            return AccesoriosDAO.GetNameAndValue(lstdto);
        }
        public static List<AccesoriosDTO> BuscarPorNombre(List<string> nombres)
        {
            return AccesoriosDAO.BuscarPorNombre(nombres);
        }

        public static List<AccesoriosDTO> MostrarAccesoriosPorId(int id)
        {
            return AccesoriosDAO.GetAccesoriosById(id);
        }
        public static void ModificarAccesorios(string query)
        {
            AccesoriosDAO.ModificarAccesorios(query);
        }
        public static void ModificarAccesoriosPorDTO(AccesoriosDTO dto)
        {
            AccesoriosDAO.ModificarAccesoriosPorDTO(dto);
        }
        public static void AgregarAccesorios(string query)
        {
            AccesoriosDAO.AgregarAccesorios(query);
        }
        public static void AgregarAccesoriosPorDTO(AccesoriosDTO dto)
        {
            AccesoriosDAO.AgregarAccesoriosPorDTO(dto);
        }
        public static void EliminarAccesorios(int id)
        {
            AccesoriosDAO.EliminarAccesorios(id);
        }
        public static int ProximoIdAccesorios()
        {
            int Id = AccesoriosDAO.ObtenerProximoId();
            if (Id != 0)
            {
                return Id;
            }
            return 0;
        }
    }
}
