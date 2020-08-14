using _4_TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1VentasDTOs
{
    public class CarritoDTO : DTOBase
    {
        public int IdVehiculo           { get; set; }
        public List<int> IDsAccesorios  { get; set; }


    }
}
