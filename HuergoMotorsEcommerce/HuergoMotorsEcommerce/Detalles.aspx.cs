using HuergoMotorsEcommerce.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HuergoMotorsEcommerce
{
    public partial class Detalles1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["usuario"] != null)
                {
                    if (!IsPostBack)
                    {
                        WebService.WebService ws = new WebService.WebService();
                        VehiculosDTO vehiculo = ws.GetVehiculosbyId(Convert.ToInt32(Request.QueryString["id"]));

                        Imagen.Attributes["src"] = ws.GetImagenes(1);
                        lblModelo.Text = vehiculo.Modelo;
                        lblPrecio.Text = "$ " + vehiculo.PrecioVenta.ToString(); 
                        if (vehiculo.StockDisponible > 0)
                        {
                            lblstock.Text = "En stock";
                        }
                        else
                        {
                            lblstock.Text = "Actualmente no se encuentra en stock";
                        }
                        AccesoriosDTO[] accesorios = ws.GetAccesoriosByModelo(vehiculo.Modelo);
                        CheckBoxList1.DataSource = accesorios;
                        CheckBoxList1.DataTextField = "Nombre";
                        CheckBoxList1.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}