using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Rep_priceplan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime localDate1 = DateTime.Now;

        Label1.Text = localDate1.ToString("yyyy/MM/dd");

    }

    protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}