using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace StateManagement
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        
        }
        protected void Session_Start(object sender, EventArgs e)
        {   
            Response.Write("Session_Start");
        }
        protected void Session_End(object sender, EventArgs e)
        {
            Response.Write("Session_End");
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
            string strError;
            strError = Server.GetLastError().ToString();
            if (Context != null)
            {
                Context.ClearError();
                Response.Write("Application_Error" + "<br/>");
                Response.Write("<b>Error Msg:</b>" + strError + "<br/>" + "<b>End Error Msg<b/>");
            }
        }

    }
}