using HuergoMotorsEcommerce.WebService;
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
            WebService.WebService ws = new WebService.WebService();

            AccesoriosDTO[] dto = ws.GetAccesorios();

            
        }
    }
}