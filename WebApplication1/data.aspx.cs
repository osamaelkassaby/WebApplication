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
    public partial class data : System.Web.UI.Page
    {
        String id;
        String name;
        String level;
        String gpa;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null && Session["password"] != null)
            {

                if (Request.QueryString["id"] != null)
                {
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "students.txt");
                    if (Request.QueryString["send"] == "add")
                    {
                        id = Request.QueryString["id"];
                        name = Request.QueryString["name"];
                        level = Request.QueryString["level"];
                        gpa = Request.QueryString["gpa"];

                        StreamReader sr = new StreamReader(filePath , false);
                        string sr_data = sr.ReadToEnd();
                        sr.Close();
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(sr_data + id + "☭" + name + "☭" + level + "☭" + gpa);
                        sw.Close();
                        Response.Redirect("add.aspx");
                    }

                    if (Request.QueryString["send"] == "update")
                    {
                        id = Request.QueryString["id"];
                        name = Request.QueryString["name"];
                        level = Request.QueryString["level"];
                        gpa = Request.QueryString["gpa"];
                        char o = '☭';
                        string[] path_file = File.ReadAllLines(filePath);
                        StreamReader sr = new StreamReader(filePath);
                        string sr_data = sr.ReadToEnd();
                        sr.Close();
                        bool close = false;
                        StreamWriter writer = new StreamWriter(filePath);
                        foreach (string line in path_file)
                        {
                            string[] data = line.Split(o);
                            // MessageBox.Show(data[1]);
                            if (data[0] == id)
                            {

                                data[1] = name;
                                data[2] = level;
                                data[3] = gpa;
                             

                            }
                            writer.WriteLine(data[0] + "☭" + data[1] + "☭" + data[2] + "☭" + data[3]);
                            close = true;
                        }
                        if(close == true)
                        {
                            writer.Close();
                            Response.Redirect("update.aspx");
                        }

                    }

                    if (Request.QueryString["send"] == "delete")
                    {
                        id = Request.QueryString["id"];
                        name = Request.QueryString["name"];
                        level = Request.QueryString["level"];
                        gpa = Request.QueryString["gpa"];

                        char o = '☭';
                        string[] path_file = File.ReadAllLines(filePath);
                        StreamReader sr = new StreamReader(filePath);
                        string sr_data = sr.ReadToEnd();
                        sr.Close();
                        StreamWriter streamWriter = new StreamWriter(filePath);
                        bool found = false;
                        foreach (string line in path_file)
                        {
                            string[] data = line.Split(o);
                            // MessageBox.Show(data[1]);
                            if (data[0] != id)
                            {
                                streamWriter.WriteLine(data[0] + "☭" + data[1] + "☭" + data[2] + "☭" + data[3]);




                                found = true;
  
                            }


                        }
                        if (found == true)
                        {
                            
                            streamWriter.Close();
                            Response.Redirect("delete.aspx");
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
}