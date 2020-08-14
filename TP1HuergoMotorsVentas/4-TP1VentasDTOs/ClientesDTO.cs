using _4_TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1VentasDTOs
{
    public class ClientesDTO : DTOBase
    {
        //Usado para el nombre de la tabla
        public bool Clientes { get; set; }
        //public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
