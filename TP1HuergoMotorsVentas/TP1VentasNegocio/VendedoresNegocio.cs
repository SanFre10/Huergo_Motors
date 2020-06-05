using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDatos;

namespace TP1VentasNegocio
{
    public class VendedoresNegocio
    {
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
