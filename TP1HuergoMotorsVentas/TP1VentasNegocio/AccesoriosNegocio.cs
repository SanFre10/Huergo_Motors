using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDatos;

namespace TP1VentasNegocio
{
    public class AccesoriosNegocio
    {
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
