using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDatos;

namespace TP1VentasNegocio
{
    public class ClientesNegocio
    {
        public static List<ClientesDTO> MostrarClientes(string filtro)
        {
            return ClientesDAO.GetClientes(filtro);
        }
        public static List<string> MostrarNombreClientes(List<ClientesDTO> dtolist)
        {
            List<string> ret = new List<string>();
            foreach (ClientesDTO dto in dtolist)
            {
                ret.Add(dto.Nombre);
            }
            return ret;
        }

        public static ClientesDTO MostrarClientesPorId(int Id)
        {
            return DAOBase<ClientesDTO>.Read(Id);
        }
        public static void ModificarClientesPorDTO(ClientesDTO dto)
        {
            DAOBase<ClientesDTO>.Update(dto);
        }
        public static void AgregarClientesPorDTO(ClientesDTO dto)
        {
            DAOBase<ClientesDTO>.Insert(dto);
        }
        public static void EliminarClientes(int Id)
        {
            DAOBase<ClientesDTO>.Delete(Id);
        }
        public static int ProximoIdClientes()
        {
            return DAOBase<ClientesDTO>.ObtenerProximoId();
        }
    }
}
