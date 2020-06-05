using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDatos;

namespace TP1VentasNegocio
{
    public class VentasNegocio
    {
        public static int ProximoIdVentas()
        {
            return VentasDAO.ObtenerProximoId();
        }
        public static string ExecTransaction(List<int> IDs, List<AccesoriosDTO> dtosAccesorios, string obs, decimal tot, int stock)
        {
            return VentasDAO.ExecTransaction(IDs, dtosAccesorios, obs, tot, stock);
        }
        public static List<VentasDTO> MostrarVentas()
        {
            return VentasDAO.GetVentas();
        }
        public static List<VentasDTO> ObtenerConFiltro(string filtro, string elegido, string inicio, string fin)
        {
            return VentasDAO.ObtenerConFiltro(filtro, elegido, inicio, fin);
        }
    }
}