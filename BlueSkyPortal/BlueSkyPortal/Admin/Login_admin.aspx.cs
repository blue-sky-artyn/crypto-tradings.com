using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Login_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Txt_user.Text == "")
        {

        }

        if (Txt_pass.Text == "")
        {

        }


        string username = string.Empty;

        using (DataSetTableAdapters.AdminTableAdapter pass = new DataSetTableAdapters.AdminTableAdapter())
        {
            DataSet.AdminDataTable mess = pass.Search_pass_admin(Txt_user.Text, Txt_pass.Text);
            foreach (DataSet.AdminRow date2 in mess)
            {
                // i = 1;
                username = Txt_user.Text;
                HttpCookie mycookie = new HttpCookie("Login_admin");
                mycookie.Values.Add("username_admin", username);
                Response.Cookies.Add(mycookie);
                Session["Id_admin"] = date2.ID_Admin;
                 Response.Redirect("Menu_admin.aspx");

            }
        }

    }
}