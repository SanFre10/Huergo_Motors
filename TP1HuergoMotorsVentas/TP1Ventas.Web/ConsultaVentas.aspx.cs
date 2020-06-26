using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using TP1VentasDTOs;
using TP1VentasNegocio;

namespace TP1Ventas.Web
{
    public partial class ConsultaVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTablaEntera();
            }

        }

        private void CargarTablaEntera()
        {
            List<VentasDTO> dtoVentas = VentasNegocio.MostrarVentas();
            Session.Add("dtoVentas", dtoVentas);
            dtgVentas.DataSource = dtoVentas;
            dtgVentas.DataBind();
        }

        protected void btBuscar_Click1(object sender, EventArgs e)
        {
            try
            {
                List<VentasDTO> dtoVentas = VentasNegocio.ObtenerConFiltro(txFiltro.Text, RadioButtonList1.SelectedItem.Text, dtpInicio.Text, dtpFin.Text);
                if (dtoVentas.Count > 0)
                {
                    dtgVentas.DataSource = dtoVentas;
                    dtgVentas.DataBind();
                    Session.Add("dtoVentas", dtoVentas);
                }
                else
                {
                    CargarTablaEntera();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void btncsv_Click1(object sender, EventArgs e)
        {
            try
            {
                //Recupera los datos el DataGrid
                List<VentasDTO> source = (List<VentasDTO>)Session["dtoVentas"];
                //Instancia el Writer en el filename del SaveFileDialog
                using (var Sw = new StreamWriter(Server.MapPath("~/Ventas.csv")))
                {
                    foreach (VentasDTO tmp in source)
                    {
                        string fecha = tmp.Fecha.ToString("d/M/yyyy");
                        Sw.WriteLine("'" + tmp.Id.ToString(CultureInfo.InvariantCulture) + "','" + fecha + "','" + tmp.Vehiculo.ToString(CultureInfo.InvariantCulture) + "','" +
                            tmp.Cliente.ToString(CultureInfo.InvariantCulture) + "','" + tmp.Vendedor.ToString(CultureInfo.InvariantCulture) + "','" +
                            tmp.Observaciones.ToString(CultureInfo.InvariantCulture) + "','" + tmp.Total.ToString(CultureInfo.InvariantCulture) + "'");
                    }
                    //Cierra el Writer
                    Sw.Close();

                    string path = "~/Ventas.csv";
                    string name = Path.GetFileName(path); //get file name

                    Response.AppendHeader("content-disposition", "attachment; filename=" + name);

                    Response.WriteFile(path);

                    Response.End();



                }
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }

        }
    }
}