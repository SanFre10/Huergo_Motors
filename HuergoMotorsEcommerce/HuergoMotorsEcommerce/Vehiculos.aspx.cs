using HuergoMotorsEcommerce.WebService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;



namespace HuergoMotorsEcommerce
{
    public partial class Vehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(Session["usuario"] != null)
                {
                    if (!IsPostBack)
                    {
                        WebService.WebService ws = new WebService.WebService();
                        VehiculosDTO[] Vehiculos = ws.GetVehiculos();
                        CargarDTOs(Vehiculos);

                        string[] filtros = { "Modelo", "Tipo" };
                        ddlBusqueda.DataSource = filtros;
                        ddlBusqueda.DataBind();
  
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

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            WebService.WebService ws = new WebService.WebService();
            VehiculosDTO[] vehiculos = new VehiculosDTO[] { };
            if (txFiltro.Text != "")
            {
                vehiculos = ws.GetVehiculosFiltrados(ddlBusqueda.SelectedValue, txFiltro.Text);
            }
            else
            {
                vehiculos = ws.GetVehiculos();
            }
            CargarDTOs(vehiculos);
        }

        protected void CargarDTOs(VehiculosDTO[] vehiculos)
        {
            //Carga todos los vehiculos disponibles al html
            foreach (VehiculosDTO v in vehiculos)
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                div.Attributes["class"] = "item";


                Button button = new Button();
                button.ID = v.Id.ToString();
                button.Text = "Ir a detalles";
                button.PostBackUrl = "Detalles.aspx?id=" + button.ID;
                button.Attributes["class"] = "btnDetalles";
                    

                HtmlGenericControl imagen = new HtmlGenericControl("img");
                imagen.Attributes["Source"] = "bin/car-icon.png";
                imagen.Attributes["class"] = "Imagen";

                HtmlGenericControl modelo = new HtmlGenericControl("p");
                modelo.Attributes["class"] = "lblmodelo";
                modelo.InnerText = v.Modelo;

                HtmlGenericControl precio = new HtmlGenericControl("p");
                precio.Attributes["class"] = "lblprecio";
                precio.InnerText = "$ " + v.PrecioVenta.ToString();

                
                div.Controls.Add(imagen);
                div.Controls.Add(modelo);
                div.Controls.Add(precio);
                div.Controls.Add(button);

                divVehiculos.Controls.Add(div);
            }
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}