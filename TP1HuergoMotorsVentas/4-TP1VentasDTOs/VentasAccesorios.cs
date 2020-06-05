using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1VentasDTOs.DTOs
{
    public class VentasAccesorios
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdAccesorio { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}
