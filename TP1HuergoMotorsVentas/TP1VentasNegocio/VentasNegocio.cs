﻿using System.Collections.Generic;
using TP1VentasDatos;
using TP1VentasDTOs;

namespace TP1VentasNegocio
{
    public class VentasNegocio
    {
        public static int ProximoIdVentas()
        {
            return DAOBase<VentasDTO>.ObtenerProximoId();
        }
        public static string ExecTransaction(int IdVehiculo, int IdCliente, int IdVendedor, List<AccesoriosDTO> dtosAccesorios, string obs, decimal tot)
        {
            return VentasDAO.ExecTransaction(IdVehiculo,IdCliente,IdVendedor, dtosAccesorios, obs, tot);
        }
        public static List<VentasDTO> MostrarVentas()
        {
            return DAOBase<VentasDTO>.ReadAll();
        }
        public static List<VentasDTO> ObtenerConFiltro(string filtro, string elegido, string inicio, string fin)
        {
            return VentasDAO.ObtenerConFiltro(filtro, elegido, inicio, fin);
        }

    }
}