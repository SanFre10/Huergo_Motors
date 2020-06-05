using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1VentasDTOs
{
    public class VentasDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Vehiculo { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public string Observaciones { get; set; }
        public decimal Total { get; set; }
    }
}
