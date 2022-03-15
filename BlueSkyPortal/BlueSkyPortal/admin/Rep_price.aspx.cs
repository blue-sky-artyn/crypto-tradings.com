using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Rep_price : System.Web.UI.Page
{
    string date1;
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime localDate1 = DateTime.Now;
        
        Label1.Text = localDate1.ToString("yyyy/MM/dd");
    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id;
        id = GridView2.SelectedRow.Cells[0].Text;

        using (DataSetTableAdapters.CashTableAdapter ins1 = new DataSetTableAdapters.CashTableAdapter())
        {

            ins1.Insert(0, "0", GridView2.SelectedRow.Cells[1].Text, Label1.Text, "", "",1, "0", Label1.Text);
            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
        }




        using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
        {

            ins1.Delete(Convert.ToInt32(id));
            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
        }
        Response.Redirect("~/Admin/Rep_price.aspx");

    }
}