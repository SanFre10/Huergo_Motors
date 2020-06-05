using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1VentasDTOs
{
    public class VehiculosDTO
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int StockDisponible { get; set; }

    }
}
