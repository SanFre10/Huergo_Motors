using HuergoMotorsEcommerce.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace HuergoMotorsEcommerce
{
    public partial class Historial : System.Web.UI.Page
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
                        ClientesDTO cliente = (ClientesDTO)Session["usuario"];
                        VentasDTO[] ventas = ws.GetVentas(cliente.Id);
                        foreach (VentasDTO v in ventas)
                        {
                            HtmlGenericControl div = new HtmlGenericControl("div");
                            div.Attributes["class"] = "venta";


                            Button button = new Button();
                            button.ID = v.Id.ToString();
                            button.Text = "Ir a detalles";
                            button.PostBackUrl = "DetallesVentas.aspx?id=" + button.ID;
                            button.Attributes["class"] = "btnDetallesVentas";


                            HtmlGenericControl compra = new HtmlGenericControl("p");
                            compra.Attributes["class"] = "lblcompra";
                            compra.InnerText = v.Vehiculo;

                            div.Controls.Add(compra);
                            div.Controls.Add(button);

                            Compras.Controls.Add(div);
                        }
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}