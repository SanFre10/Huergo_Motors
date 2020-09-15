using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1VentasDTOs;

namespace TP1VentasDTOs
{
    public class ComprasDTO
    {
        public VentasDTO Ventas { get; set; }

        public List<AccesoriosDTO> Accesorios { get;set; }
    }
}
