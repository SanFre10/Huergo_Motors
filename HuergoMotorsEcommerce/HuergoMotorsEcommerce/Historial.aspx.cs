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
    public partial class Historial1 : System.Web.UI.Page
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
                            ComprasDTO[] ventas = ws.GetVentas(cliente.Id);
                            foreach (ComprasDTO v in ventas)
                            {
                                HtmlGenericControl card = new HtmlGenericControl("div");
                                card.Attributes["class"] = "card mb-3 mx-auto";
                                card.Attributes["style"] = "max-width: 540px";

                                HtmlGenericControl body = new HtmlGenericControl("div");
                                body.Attributes["class"] = "card-body";

                                HtmlGenericControl titulo = new HtmlGenericControl("h3");
                                titulo.Attributes["class"] = "card-title";
                                titulo.InnerText = v.Ventas.Vehiculo;

                                HtmlGenericControl fecha = new HtmlGenericControl("h4");
                                fecha.Attributes["class"] = "card-subtitle";
                                fecha.InnerText = v.Ventas.Fecha.ToString("dd/MM/yyyy");

                                HtmlGenericControl total = new HtmlGenericControl("h4");
                                total.Attributes["class"] = "card-subtitle";
                                total.InnerText = v.Ventas.Total.ToString();

                                HtmlGenericControl acc = new HtmlGenericControl("h5");
                                acc.Attributes["class"] = "card-text";
                                acc.InnerText = "Accesorios:";

                                body.Controls.Add(titulo);
                                body.Controls.Add(fecha);
                                body.Controls.Add(acc);

                                foreach (AccesoriosDTO ac in v.Accesorios)
                                {
                                    HtmlGenericControl acce = new HtmlGenericControl("p");
                                    acce.Attributes["class"] = "card-text";
                                    acce.InnerText = ac.Nombre;

                                    HtmlGenericControl p = new HtmlGenericControl("p");
                                    p.Attributes["class"] = "card-text";
                                    p.InnerHtml = "$ " + ac.PrecioVenta.ToString();




                                    body.Controls.Add(acce);
                                    body.Controls.Add(p);



                                }
                                card.Controls.Add(body);

                                Compras.Controls.Add(card);

                            }

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

