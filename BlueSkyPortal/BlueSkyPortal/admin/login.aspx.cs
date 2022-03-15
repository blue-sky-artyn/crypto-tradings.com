using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

     if(txt_username.Text == "")
        {

        }
     if(txt_pass.Text == "")
        {

        }

        string username = string.Empty;
        string pass = string.Empty;
        string name_customer = string.Empty;
        pass = txt_pass.Text;
        //  pass = Decrypt(pass);
        using (DataSetTableAdapters.AdminTableAdapter pass15 = new DataSetTableAdapters.AdminTableAdapter())
        {
            DataSet.AdminDataTable mess5 = pass15.Search_pass_admin(txt_username.Text, pass);
            foreach (DataSet.AdminRow date25 in mess5)
            {

                // i = 1;
                username = txt_username.Text;

                HttpCookie mycookie = new HttpCookie("Loginadmin");
                Response.Cookies.Add(mycookie);
                Response.Redirect("Default.aspx");

            }
        }












    }
}