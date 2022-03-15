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
        if (Request.QueryString["id"] != "")
        {
            if (Request.QueryString["id"] == "5")
            {
                lblError.Visible = true;
                

            }
        }
        }

    protected void btnEnter_Click(object sender, EventArgs e)
    {
        if (txtUser.Text != "")
            if (txtPass.Text != "")
            {
                int i5 = 0;
                string username = string.Empty;
                string pass = string.Empty;
                string name_customer = string.Empty;
                pass = txtPass.Text;
                //  pass = Decrypt(pass);
                using (DataSetTableAdapters.CustomerTableAdapter pass15 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable mess5 = pass15.Search_pass_customer(txtUser.Text, pass);
                    foreach (DataSet.CustomerRow date25 in mess5)
                    {

                        i5 = 1;
                        username = txtUser.Text;
                        name_customer = date25.Name_customer;
                        HttpCookie mycookie = new HttpCookie("Logincustomer");
                        mycookie.Values.Add("usernamecustomer", username);
                        mycookie.Values.Add("namecustomer", name_customer);
                        Response.Cookies.Add(mycookie);
                        Session["id_customer"] = date25.Id_customer;
                        Session["email_customer"] = date25.Email_custemer;
                        Session["name_customer"] = date25.Name_customer;
                        Response.Redirect("Default.aspx");

                    }
                }
            }

            }

    protected void btnReg_Click(object sender, EventArgs e)
    {
        
    }
}