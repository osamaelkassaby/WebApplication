using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"]  != null && Session["password"] != null) {
                if (Session["login"] != null)
                {
                   user.InnerText = Session["username"].ToString();
                }
            }
            else
            {
                Response.Redirect("Webform1.aspx");
            }
        }

       
    }
}