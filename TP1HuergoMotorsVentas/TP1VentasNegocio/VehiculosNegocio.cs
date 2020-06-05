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
            return VehiculosDAO.GetModelVehiculos(dtolist);
        }
        public static List <VehiculosDTO> MostrarVehiculosPorId(int id)
        {
            return VehiculosDAO.GetVehiculosById(id);
        }
        public static void ModificarVehiculos(string query)
        {
            VehiculosDAO.ModificarVehiculos(query);
        }
        public static void ModificarVehiculosPorDTO(VehiculosDTO dto)
        {
            VehiculosDAO.ModificarVehiculosPorDTO(dto);
        }
        public static void AgregarVehiculos(string query)
        {
            VehiculosDAO.AgregarVehiculos(query);
        }
        public static void AgregarVehiculosPorDTO(VehiculosDTO dto)
        {
            VehiculosDAO.AgregarVehiculosPorDTO(dto);
        }
        public static void EliminarVehiculos(int id)
        {
            VehiculosDAO.EliminarVehiculos(id);
        }
        public static int ProximoIdVehiculos()
        {
            int Id = VehiculosDAO.ObtenerProximoId();
            if (Id != 0)
            {
                return Id;
            }
            return 0;
        }
    }
}
