using _4_TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasNegocio;

namespace TP1VentasDTOs
{
    public class CarritoDTO : DTOBase
    {
        public AutoConFoto Vehiculo { get; set; }
        public List<AccesoriosDTO> Accesorios { get; set; }

    }
}
