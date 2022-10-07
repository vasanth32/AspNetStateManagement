using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UserName"] = "Session test";
            Session.Timeout = 1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Response.Cookies["CookiesName"].Value = "Testing Cookies";
            Response.Cookies["CookiesName"].Expires = DateTime.Today.AddDays(5);
            var text = Convert.ToString(HiddenField1.Value);
            Response.Write("<br/>");

            Response.Write(text);
            //Response.Redirect("Home.aspx");

        }
    }
}