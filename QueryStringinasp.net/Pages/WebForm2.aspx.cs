using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStringinasp.net.Pages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblnombre.Text = Request.QueryString["nombre"];
            //lblemail.Text = Request.QueryString["emaill"];

             lblnombre.Text = Request.QueryString[0];
            lblemail.Text = Request.QueryString[1];

        }
    }
}