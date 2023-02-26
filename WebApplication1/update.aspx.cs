using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                if (Session["login"] != null)
                {

                    user.InnerText = Session["username"].ToString();
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "students.txt");
                    string[] path_file = File.ReadAllLines(filePath);
                    string[] file = path_file;
                    char o = '☭';
                    foreach (string lines in file)
                    {
                        string[] data = lines.Split(o);


                       select_id.InnerHtml += " <option value='"+ data[0]+"'>" + data[0] +"</option>";


                    }



                }
                else
                {
                    Response.Redirect("WebForm1.aspx");
                }
            }
            else
            {
                Response.Redirect("WebForm1.aspx");

            }
        }
    }
}