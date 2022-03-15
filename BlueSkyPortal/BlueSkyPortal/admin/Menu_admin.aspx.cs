using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Menu_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.Cookies["Login_admin"] == null)
            Response.Redirect("~/Admin/Login_admin.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("In_plans.aspx");
    }
}