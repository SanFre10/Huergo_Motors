using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDatos;

namespace TP1VentasNegocio
{
    public class VentaAccesorioNegocio
    {
        public static int ProximoIdVentaAccesorios()
        {
            return VentaAccesoriosDAO.ObtenerProximoId();
        }

    }
}
