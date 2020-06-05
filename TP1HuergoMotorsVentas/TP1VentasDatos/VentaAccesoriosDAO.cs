using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1Ventas;

namespace TP1VentasDatos
{
    public class VentaAccesoriosDAO
    {
        public static int ObtenerProximoId()
        {

                return SQLHelper.ObtenerProximoId("VentasAccesorios");

        }

    }
}
