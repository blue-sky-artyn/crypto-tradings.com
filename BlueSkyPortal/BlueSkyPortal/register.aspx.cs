using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class dashboard_login : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnEnter_Click(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (txtName.Text == "")
        {
              Response.Write("<script LANGUAGE='JavaScript' >alert('Please fill in the name')</script>");
        }
    

        if (txtFamily.Text == "")
        {

        }
        if (txtEmail.Text == "")
        {

        }
        if (txtPass1.Text == "")
        {

        }

        DateTime localDate = DateTime.Now;
       
        string date = localDate.ToString("yyyy/MM/dd");
        txtAddr.Text = date;        using (DataSetTableAdapters.CustomerTableAdapter ins1 = new DataSetTableAdapters.CustomerTableAdapter())
        {

            ins1.Insert(txtName.Text, txtFamily.Text, txtEmail.Text, "", date, txtPass1.Text, txt_valet.Text, "","","",0);
         //   Response.Redirect("~/Admin/Insert_mp3.aspx");
        }


    }
}