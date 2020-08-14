using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDatos;
using TP1VentasDTOs;


namespace TP1VentasNegocio
{
    public class VehiculosNegocio
    {
        public static List<VehiculosDTO> MostrarVehiculos(string filtro)
        {
            return VehiculosDAO.GetVehiculos(filtro);
        }
        public static List<string> MostrarModeloVehiculos(List<VehiculosDTO> dtolist)
        {
            List<string> ret = new List<string>();
            foreach (VehiculosDTO dto in dtolist)
            {
                ret.Add(dto.Modelo);
            }
            return ret;
        }
        public static VehiculosDTO MostrarVehiculosPorId(int id)
        {
            return DAOBase<VehiculosDTO>.Read(id);
        }

        public static void ModificarVehiculosPorDTO(VehiculosDTO dto)
        {
            DAOBase<VehiculosDTO>.Update(dto);
        }

        public static void AgregarVehiculosPorDTO(VehiculosDTO dto)
        {
            DAOBase<VehiculosDTO>.Insert(dto);
        }
        public static void EliminarVehiculos(int id)
        {
            DAOBase<VehiculosDTO>.Delete(id);
        }
        public static int ProximoIdVehiculos()
        {
            int Id = DAOBase<VehiculosDTO>.ObtenerProximoId();
            if (Id != 0)
            {
                return Id;
            }
            return 0;
        }
    }
}
