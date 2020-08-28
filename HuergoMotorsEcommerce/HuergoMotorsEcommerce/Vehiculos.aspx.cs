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
            if (HttpContext.Current.Request.Url.AbsolutePath != "/Vehiculos.aspx")
            {
                Response.Redirect("Vehiculos.aspx");
            }

            WebService.WebService ws = new WebService.WebService();
            //Carga todos los vehiculos disponibles al html
            foreach (VehiculosDTO v in vehiculos)
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                div.Attributes["class"] = "item card mb-3 w-50 mx-auto m-5";
                div.Attributes["Style"] = "border-color:#A2192D;border-width:2px";

                HtmlGenericControl div2 = new HtmlGenericControl("div");
                div2.Attributes["class"] = "row no-gutters";

                HtmlGenericControl div3 = new HtmlGenericControl("div");
                div3.Attributes["class"] = "col-md-8";

                HtmlGenericControl imagen = new HtmlGenericControl("img");
                imagen.Attributes["class"] = "Imagen card-img-top";
                imagen.Attributes["runat"] = "server";
                imagen.Attributes["src"] = ws.GetImagenes(2);

                HtmlGenericControl link = new HtmlGenericControl("a");
                link.Attributes["href"] = "Detalles.aspx?id=" + v.Id;

                HtmlGenericControl body = new HtmlGenericControl("div");
                body.Attributes["class"] = "card-body";

                HtmlGenericControl body2 = new HtmlGenericControl("div");
                body2.Attributes["class"] = "col-md-4";

                HtmlGenericControl modelo = new HtmlGenericControl("h4");
                modelo.Attributes["class"] = "lblmodelo card-title text-decoration-none";
                modelo.Attributes["Style"] = "color:black;";
                modelo.InnerText = v.Modelo;

                HtmlGenericControl precio = new HtmlGenericControl("p");
                precio.Attributes["class"] = "lblprecio card-text text-decoration-none";
                precio.InnerText = "$ " + v.PrecioVenta.ToString();
                precio.Attributes["Style"] = "color:black;";


                div3.Controls.Add(imagen);

                body.Controls.Add(modelo);
                body.Controls.Add(precio);

                body2.Controls.Add(body);

                div2.Controls.Add(div3);
                div2.Controls.Add(body2);


                link.Controls.Add(div2);
                div.Controls.Add(link);

                divVehiculos.Controls.Add(div);
            }
        }

    }
}