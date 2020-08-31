using HuergoMotorsEcommerce.WebService;
using System;

namespace HuergoMotorsEcommerce
{
    public partial class Home1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClientesDTO dto = (ClientesDTO)Session["usuario"];
                if (dto == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    string[] filtros = { "Modelo", "Tipo" };
                    ddlBusqueda.DataSource = filtros;
                    ddlBusqueda.DataBind();
                    Session["DTO"] = null;
                }
            }
        }
        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                WebService.WebService ws = new WebService.WebService();
                Vehiculos2 v = new Vehiculos2();
                VehiculosDTO[] vehiculos = new VehiculosDTO[] { };
                if (txFiltro.Text != "")
                {
                    vehiculos = ws.GetVehiculosFiltrados(ddlBusqueda.SelectedValue, txFiltro.Text);
                }
                else
                {
                    vehiculos = ws.GetVehiculos();
                }
                Session.Add("DTO", vehiculos);
                Response.Redirect("Vehiculos.aspx?");
            }
            catch (Exception)
            {

                throw;
            }

            
        }
        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void btnVehiculos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Vehiculos.aspx");
        }

        protected void btnHistorial_Click(object sender, EventArgs e)
        {
            Response.Redirect("Historial.aspx");
        }
    }
}