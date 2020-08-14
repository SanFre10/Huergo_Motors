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
        public static List<string> MostrarNombreVendedores(List<VendedoresDTO> dtolist)
        {
            List<string> ret = new List<string>();
            foreach (VendedoresDTO dto in dtolist)
            {
                ret.Add(dto.Nombre + " " + dto.Apellido);
            }
            return ret;
        }

        public static VendedoresDTO MostrarVendedoresPorId(int Id)
        {
            return DAOBase<VendedoresDTO>.Read(Id);
        }

        public static void ModificarVendedoresPorDTO(VendedoresDTO dto)
        {
            DAOBase<VendedoresDTO>.Update(dto);
        }

        public static void AgregarVendedoresPorDTO(VendedoresDTO dto)
        {
            DAOBase<VendedoresDTO>.Insert(dto);
        }
        public static void EliminarVendedores(int Id)
        {
            DAOBase<VendedoresDTO>.Delete(Id);
        }
        public static int ProximoIdVendedores()
        {
            int Id = DAOBase<VendedoresDTO>.ObtenerProximoId();
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
