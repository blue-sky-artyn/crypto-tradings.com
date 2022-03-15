using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_insert_email : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Loginadmin"] == null)
        {
            Response.Redirect("login.aspx");
        }
        if (!IsPostBack)
        { 
        using (DataSetTableAdapters.email_registerTableAdapter ins11 = new DataSetTableAdapters.email_registerTableAdapter())
        {
            DataSet.email_registerDataTable ne11 = ins11.select_email1();
            foreach (DataSet.email_registerRow row3 in ne11)
            {
                txt_subregister.Text = row3.Subject;
                txt_bodyregister.Text = row3.Body;
                txt_subprice.Text = row3.Subject1;
                txt_bodyprice.Text = row3.Body1;
                txt_Lottery.Text = row3.Desk_emilregister1;

            }

        }
    }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        using (DataSetTableAdapters.email_registerTableAdapter ins12 = new DataSetTableAdapters.email_registerTableAdapter())
        {

            ins12.update_email1(1,txt_bodyregister.Text,txt_subregister.Text,txt_bodyprice.Text,txt_subprice.Text,txt_Lottery.Text);

               Response.Redirect("~/Admin/Default.aspx");
        }

    }
}