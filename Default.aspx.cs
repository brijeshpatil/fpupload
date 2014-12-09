using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //FileUpload1.SaveAs(Server.MapPath("MyFolder/" + FileUpload1.FileName));
        if (File.Exists("D:/myfile.txt"))
        {
            StreamReader sr = File.OpenText("D:/myfile.txt");
            Response.Write(sr.ReadLine());
            sr.Close();
        }
        else
        {
            Response.Write("Not Found.....");
        }
    }
}
