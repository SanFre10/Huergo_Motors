using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDTOs;

namespace TP1VentasNegocio
{
    public class AutoConFoto
    {
        public VehiculosDTO Vehiculo { get; set; }
        public List<VehiculosImagenesDTO> Fotos { get; set; }
    }
}
