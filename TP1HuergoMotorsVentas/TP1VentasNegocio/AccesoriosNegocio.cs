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
        public static List<string> MostrarNombreYPrecioAccesorios(List<AccesoriosDTO> dtolist)
        {
            List<string> ret = new List<string>();
            foreach (AccesoriosDTO dto in dtolist)
            {
                ret.Add(dto.Nombre + "-" + dto.PrecioVenta);
            }
            return ret;
        }
        public static List<AccesoriosDTO> BuscarPorNombre(List<string> nombres)
        {
            return AccesoriosDAO.BuscarPorNombre(nombres);
        }

        public static AccesoriosDTO MostrarAccesoriosPorId(int id)
        {
            return DAOBase<AccesoriosDTO>.Read(id);
        }
        public static void ModificarAccesoriosPorDTO(AccesoriosDTO dto)
        {
            DAOBase<AccesoriosDTO>.Update(dto);
        }
        public static void AgregarAccesoriosPorDTO(AccesoriosDTO dto)
        {
            DAOBase<AccesoriosDTO>.Insert(dto);
        }
        public static void EliminarAccesorios(int id)
        {
            DAOBase<AccesoriosDTO>.Delete(id);
        }
        public static int ProximoIdAccesorios()
        {
            int Id = DAOBase<AccesoriosDTO>.ObtenerProximoId();
            if (Id != 0)
            {
                return Id;
            }
            return 0;
        }
    }
}
