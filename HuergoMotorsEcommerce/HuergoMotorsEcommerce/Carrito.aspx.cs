using HuergoMotorsEcommerce.WebService;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace HuergoMotorsEcommerce
{
    public partial class Carrito : System.Web.UI.Page
    {
        decimal total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {

                Cargar_Cards();
                

            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
        protected void Cargar_Cards()
        {
            PlaceHolder1.Controls.Clear();
            List<CarritoDTO> carrito = (List<CarritoDTO>)Session["carrito"];
            if (carrito != null && carrito.Count > 0)
            {
                foreach (CarritoDTO item in carrito)
                {

                    HtmlGenericControl card = new HtmlGenericControl("div");
                    card.Attributes["class"] = "card mb-3 mx-auto";
                    card.Attributes["style"] = "max-width: 540px";

                    HtmlGenericControl row = new HtmlGenericControl("div");
                    row.Attributes["class"] = "row no-gutters";

                    HtmlGenericControl col1 = new HtmlGenericControl("div");
                    col1.Attributes["class"] = "col-md-4";

                    HtmlGenericControl imagen = new HtmlGenericControl("img");
                    imagen.Attributes["class"] = "card-img";
                    if (item.Vehiculo.Fotos.Length > 0)
                    {
                        imagen.Attributes["src"] = "data:image/png;base64," + Convert.ToBase64String(item.Vehiculo.Fotos[0].Foto);
                    }
                    else
                    {
                        imagen.Attributes["src"] = "car-icon.png";
                    }


                    HtmlGenericControl col2 = new HtmlGenericControl("div");
                    col2.Attributes["class"] = "col-md-8";

                    HtmlGenericControl body = new HtmlGenericControl("div");
                    body.Attributes["class"] = "card-body";

                    HtmlGenericControl titulo = new HtmlGenericControl("h4");
                    titulo.Attributes["class"] = "card-title";
                    titulo.InnerText = item.Vehiculo.Vehiculo.Modelo + " $" + item.Vehiculo.Vehiculo.PrecioVenta;

                    Button button1 = new Button();
                    button1.ID = item.Vehiculo.Vehiculo.Id.ToString();
                    button1.Text = "X";
                    button1.Click += new EventHandler(BorrarAuto_Click);


                    titulo.Controls.Add(button1);


                    total += item.Vehiculo.Vehiculo.PrecioVenta;

                    body.Controls.Add(titulo);

                    foreach (AccesoriosDTO ac in item.Accesorios)
                    {
                        HtmlGenericControl acce = new HtmlGenericControl("p");
                        acce.Attributes["class"] = "card-text mx-auto";
                        acce.InnerText = ac.Nombre + " $" + ac.PrecioVenta;

                        Button button = new Button();
                        button.ID = ac.Id.ToString();
                        button.Text = "X";
                        button.Click += new EventHandler(BorrarAccesorio_Click);


                        acce.Controls.Add(button);

                        body.Controls.Add(acce);


                        total += ac.PrecioVenta;
                    }
                    col2.Controls.Add(body);

                    HtmlGenericControl footer = new HtmlGenericControl("div");
                    footer.Attributes["class"] = "card-footer";

                    HtmlGenericControl precio = new HtmlGenericControl("h5");
                    precio.Attributes["class"] = "card-text";
                    precio.InnerText = "Total: $" + total.ToString();

                    footer.Controls.Add(precio);

                    col2.Controls.Add(footer);

                    col1.Controls.Add(imagen);

                    row.Controls.Add(col1);
                    row.Controls.Add(col2);

                    card.Controls.Add(row);

                    PlaceHolder1.Controls.Add(card);
                }
                Button comprar = new Button();
                comprar.Text = "Comprar";
                comprar.CssClass = "btn btn-danger";
                comprar.Attributes["style"] = "margin-left:45%";
                comprar.Click += new EventHandler(Comprar_Click);
                PlaceHolder1.Controls.Add(comprar);
            }
            else
            {
                HtmlGenericControl a = new HtmlGenericControl("h2");
                a.InnerText = "Carrito vacio!";
                PlaceHolder1.Controls.Add(a);
            }
        }
        protected void BorrarAuto_Click(object sender, EventArgs e)
        {
            List<CarritoDTO> carrito = (List<CarritoDTO>)Session["carrito"];
            Button button = (Button)sender;
            string Id = button.ID;

            foreach(CarritoDTO c in carrito)
            {
                if(c.Vehiculo.Vehiculo.Id == Convert.ToInt32(Id))
                {
                    carrito.Remove(c);
                    break;
                }
            }
            
        }
        protected void BorrarAccesorio_Click(object sender, EventArgs e)
        {
            List<CarritoDTO> carrito = (List<CarritoDTO>)Session["carrito"];
            Button button = (Button)sender;
            string Id = button.ID;

            foreach (CarritoDTO c in carrito)
            {
                foreach (AccesoriosDTO ac in c.Accesorios)
                {
                    if (ac.Id == Convert.ToInt32(Id))
                    {
                        List<AccesoriosDTO> lista = new List<AccesoriosDTO>();
                        lista = c.Accesorios.ToList();
                        lista.Remove(ac);
                        c.Accesorios = lista.ToArray();
                        break;
                    }
                }

            }
        }
        protected void Comprar_Click(object sender, EventArgs e)
        {
            
            WebService.WebService ws = new WebService.WebService();
            List<CarritoDTO> carrito = (List<CarritoDTO>)Session["carrito"];
            ClientesDTO cliente = (ClientesDTO)Session["usuario"];
            foreach(CarritoDTO c in carrito)
            {
                ws.CrearVenta(c.Vehiculo.Vehiculo.Id, cliente.Id, 1, c.Accesorios, "", total);
                
            }
            carrito.Clear();
            Session["carrito"] = null;
            Cargar_Cards();

        }

    }
}