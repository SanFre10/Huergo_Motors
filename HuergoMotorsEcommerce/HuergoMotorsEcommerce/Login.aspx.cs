﻿using HuergoMotorsEcommerce.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HuergoMotorsEcommerce
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                WebService.WebService ws = new WebService.WebService();

                ClientesDTO dto = ws.IniciarSesion(txUser.Text, txPass.Text);

                if (dto != null)
                {
                    lblMsg.Text = "Sesión iniciada correctamente.";


                    Session.Add("usuario", dto);
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    lblMsg.Text = "Usuario o contraseña incorrecta.";
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }


        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
    }
}