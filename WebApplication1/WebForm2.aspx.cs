using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml.Linq;
namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
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
                        datagride.InnerHtml += "<div class='products-row'>";

                        datagride.InnerHtml += "<div class='product-cell image'>";
                        datagride.InnerHtml += "<span style = 'font-size:20px;' > " + data[0] +" </span>";
                        datagride.InnerHtml+= "</div>";
                        datagride.InnerHtml += "<div class='product-cell'><span></span>" + data[1] +"</div>";
                  
                        datagride.InnerHtml += "<div class='product-cell sales'><span class='cell-label'></span>" + data[2]+"</div>";
                        datagride.InnerHtml += "<div class='product-cell stock'><span class='cell-label'></span>" + data[3]+"</div>";
                        datagride.InnerHtml += "</div>";





                    }




                }
            }
            else
            {
                Response.Redirect("WebForm1.aspx");
            }
        
        }
    }
}
