﻿using _4_TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1VentasDTOs
{
    public class VendedoresDTO : DTOBase
    {
        //Usado para el nombre de la tabla
        public bool Vendedores { get; set; }
        //public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sucursal { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

    }
}
