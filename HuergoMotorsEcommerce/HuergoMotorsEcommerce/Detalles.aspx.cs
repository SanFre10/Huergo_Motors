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
                        AutoConFoto vehiculo = ws.GetVehiculosbyId(Convert.ToInt32(Request.QueryString["id"]));
                        Session["elegido"] = vehiculo;
                        if (vehiculo.Fotos.Length > 0)
                        {
                            foreach (VehiculosImagenesDTO foto in vehiculo.Fotos)
                            {
                                HtmlGenericControl div = new HtmlGenericControl("div");
                                if (vehiculo.Fotos.First() == foto)
                                {
                                    div.Attributes["class"] = "carousel-item active";
                                }
                                else
                                {
                                    div.Attributes["class"] = "carousel-item";
                                }

                                HtmlGenericControl img = new HtmlGenericControl("img");
                                img.Attributes["class"] = "d-block w-100";
                                img.Attributes["style"] = "max-height:425px";
                                img.Attributes["src"] = "data:image/png;base64," + Convert.ToBase64String(foto.Foto);

                                div.Controls.Add(img);

                                PlaceHolder1.Controls.Add(div);
                            }
                        }
                        else
                        {
                            HtmlGenericControl div = new HtmlGenericControl("div");
                            div.Attributes["class"] = "carousel-item active";
                            HtmlGenericControl img = new HtmlGenericControl("img");
                            img.Attributes["class"] = "d-block w-100";
                            img.Attributes["style"] = "max-height:425px";
                            img.Attributes["src"] = "car-icon.png";
                            div.Controls.Add(img);
                            PlaceHolder1.Controls.Add(div);
                        }

                        lblModelo.Text = vehiculo.Vehiculo.Modelo;
                        lblPrecio.Text = "$ " + vehiculo.Vehiculo.PrecioVenta.ToString();
                        lblDescripcion.Text = vehiculo.Vehiculo.Descripcion;
                        if (vehiculo.Vehiculo.StockDisponible > 0)
                        {
                            lblstock.Text = "En stock";
                        }
                        else
                        {
                            lblstock.Text = "Actualmente no se encuentra en stock";
                        }
                        AccesoriosDTO[] accesorios = ws.GetAccesoriosByModelo(vehiculo.Vehiculo.Modelo);
                        CheckBoxList1.DataSource = accesorios;
                        CheckBoxList1.DataValueField = "Id";
                        CheckBoxList1.DataTextField = "Nombre";
                        CheckBoxList1.DataBind();
                        if(accesorios.Length > 0)
                        {
                            lblAccesorios.Text = "Accesorios disponibles";
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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            WebService.WebService ws = new WebService.WebService();
            List<CarritoDTO> carrito = new List<CarritoDTO>();
            if (Session["carrito"] != null)
            {
                carrito = (List<CarritoDTO>)Session["carrito"];
            }

            CarritoDTO dto = new CarritoDTO();
            AutoConFoto vehiculo = (AutoConFoto)Session["elegido"];
            AccesoriosDTO[] accesorios = { };
            List<int> list = new List<int>();

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    list.Add(Convert.ToInt32(item.Value));
                }
            }
            
            if (list.Count > 0)
            {
                accesorios = ws.GetAccesoriosByIds(list.ToArray());
            }

            dto.Vehiculo = vehiculo;
            dto.Accesorios = accesorios;

            bool existe = false;
            foreach(CarritoDTO car in carrito)
            {
                if(car.Vehiculo.Vehiculo.Id == dto.Vehiculo.Vehiculo.Id)
                {
                    existe = true;
                    break;
                }
            }
            if(existe == false)
            {
                carrito.Add(dto);
                Session["carrito"] = carrito;
                Response.Redirect("/Carrito.aspx");
            }
            else
            {
                lblmsg.Text = "El auto ya existe en el carrito";
            }



            



        }
    }
}