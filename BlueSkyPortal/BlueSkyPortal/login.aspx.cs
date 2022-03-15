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
        if(txtUser.Text == "")
        {

        }

        if (txtPass.Text == "")
        {

        }


        string username = string.Empty;

        using (DataSetTableAdapters.CustomerTableAdapter pass = new DataSetTableAdapters.CustomerTableAdapter())
        {
            DataSet.CustomerDataTable mess = pass.Search_pass_customer(txtUser.Text, txtPass.Text);
            foreach (DataSet.CustomerRow date2 in mess)
            {
                // i = 1;
                username = txtUser.Text;
                HttpCookie mycookie = new HttpCookie("Login_customer");
                mycookie.Values.Add("username_customer", username);
                Response.Cookies.Add(mycookie);
                Session["Id_customer"] = date2.Id_customer;
              //  Response.Redirect("admin_p1.aspx");

            }
        }



    }
    protected void btnReg_Click(object sender, EventArgs e)
    {
        
    }
}