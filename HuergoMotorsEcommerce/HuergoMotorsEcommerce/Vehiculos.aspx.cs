using HuergoMotorsEcommerce.WebService;
using System;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace HuergoMotorsEcommerce
{
    public partial class Vehiculos2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["usuario"] != null)
                {
                    if (!IsPostBack)
                    {
                        VehiculosDTO[] Vehiculos = new VehiculosDTO[] { };
                        if (Session["DTO"] != null)
                        {
                            Vehiculos = (VehiculosDTO[])Session["DTO"];
                        }
                        else
                        {
                            WebService.WebService ws = new WebService.WebService();
                            Vehiculos = ws.GetVehiculos();
                        }

                        CargarDTOs(Vehiculos);

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

        

        public void CargarDTOs(VehiculosDTO[] vehiculos)
        {
            if(HttpContext.Current.Request.Url.AbsolutePath != "/Vehiculos.aspx")
            {
                Response.Redirect("Vehiculos.aspx");
            }

            WebService.WebService ws = new WebService.WebService();
            //Carga todos los vehiculos disponibles al html
            foreach (VehiculosDTO v in vehiculos)
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                div.Attributes["class"] = "item card w-50 mx-auto m-5";


                Button button = new Button();
                button.ID = v.Id.ToString();
                button.Text = "Ir a detalles";
                button.PostBackUrl = "Detalles.aspx?id=" + button.ID;
                button.Attributes["class"] = "btnDetalles btn btn-primary";


                HtmlGenericControl imagen = new HtmlGenericControl("img");
                imagen.Attributes["Source"] = "bin/car-icon.png";
                imagen.Attributes["class"] = "Imagen card-img-top";
                imagen.Attributes["runat"] = "server";
                imagen.Attributes["src"] = ws.GetImagenes(2);

                HtmlGenericControl body = new HtmlGenericControl("div");
                body.Attributes["class"] = "card-body";

                HtmlGenericControl modelo = new HtmlGenericControl("p");
                modelo.Attributes["class"] = "lblmodelo card-title";
                modelo.InnerText = v.Modelo;

                HtmlGenericControl precio = new HtmlGenericControl("p");
                precio.Attributes["class"] = "lblprecio card-text";
                precio.InnerText = "$ " + v.PrecioVenta.ToString();

                body.Controls.Add(modelo);
                body.Controls.Add(precio);
                body.Controls.Add(button);

                div.Controls.Add(imagen);
                div.Controls.Add(body);

                divVehiculos.Controls.Add(div);
            }
        }

    }
}