using HuergoMotorsEcommerce.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HuergoMotorsEcommerce
{
    public partial class Mis_datos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["usuario"] != null)
            {
                if (!IsPostBack)
                {
                    ClientesDTO usuario = (ClientesDTO)Session["usuario"];

                    txNombre.Text = usuario.Nombre;
                    txEmail.Text = usuario.Email;
                    txDireccion.Text = usuario.Direccion;
                    txTelefono.Text = usuario.Telefono;
                    txUsuario.Text = usuario.Usuario;
                    txContraseña.Text = usuario.Contraseña;
                }
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            WebService.WebService ws = new WebService.WebService();
            ClientesDTO usuario = (ClientesDTO)Session["usuario"];
            ClientesDTO dto = new ClientesDTO
            {
                Id = usuario.Id,
                Nombre = txNombre.Text,
                Direccion = txDireccion.Text,
                Telefono = txTelefono.Text,
                Email = txEmail.Text,
                Usuario = txUsuario.Text,
                Contraseña = txContraseña.Text
            };

            ws.ActualizarUsuario(dto);
            Session["usuario"] = dto;


        }
    }
}