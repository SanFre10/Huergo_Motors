using _4_TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1VentasDTOs
{
    public class AccesoriosDTO : DTOBase
    {
        //Usado para el nombre de la tabla
        public bool Accesorios { get; set; }
        //public int Id { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public decimal PrecioVenta { get; set; }
        
    }
}
