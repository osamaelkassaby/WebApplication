using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        String username;
        String password;
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if (Request.QueryString["username"] != null)
                {

                    username = Request.QueryString["username"];
                    password = Request.QueryString["password"];

                try
                {
                    char o = '☭';

                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "users.txt");
                    string[] path_file = File.ReadAllLines(filePath);
                    string[] file = path_file;
                    foreach(string lines in file)
                    {
                        string[] data = lines.Split(o);
                        if (data[0] == username)
                        {
                            if (data[1] == password)
                            {
                                Session["username"] = username;
                                Session["password"] = password;
                                Session["login"] = 1;
                                Response.Redirect("WebForm2.aspx");
                            }
                        }
                        else
                        {
                            
                            Response.Redirect("WebForm1.aspx");
                        }
                    }

                }
                catch (Exception)
                {
                    throw;
                    Response.Redirect("WebForm1.aspx?error");
                }

            }
            else
            {
                    Response.Redirect("WebForm1.aspx?error");

            }

            }
        }
    }
