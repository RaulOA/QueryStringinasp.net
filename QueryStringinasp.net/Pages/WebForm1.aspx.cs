using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace QueryStringinasp.net.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx?nombre=" + Server.UrlEncode(txtnombre.Text) + "&emaill=" + Server.UrlEncode(txtemail.Text));
        }
    }
}