using _4_TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1VentasDTOs.DTOs
{
    public class VentasAccesoriosDTO : DTOBase
    {
        //Usado para el nombre de la tabla
        public bool VentasAccesorios { get; set; }
        //public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdAccesorio { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}
