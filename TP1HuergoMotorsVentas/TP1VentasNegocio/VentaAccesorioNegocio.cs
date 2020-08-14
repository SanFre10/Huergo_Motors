using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDatos;
using TP1VentasDTOs.DTOs;

namespace TP1VentasNegocio
{
    public class VentaAccesorioNegocio
    {
        public static int ProximoIdVentaAccesorios()
        {
            return DAOBase<VentasAccesoriosDTO>.ObtenerProximoId();
        }

    }
}
