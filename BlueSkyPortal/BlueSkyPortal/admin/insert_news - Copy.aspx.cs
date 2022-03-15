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
       
  
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
      //  Image = "";

       
         


            using (DataSetTableAdapters.Select_soalTableAdapter ins12 = new DataSetTableAdapters.Select_soalTableAdapter())
            {

                ins12.Insert(txt_titr.Text, txt_text.Text, 0,"","");

                Response.Redirect("default.aspx");
            }
        }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Txt_delete.Text = Convert.ToString(GridView1.SelectedRow.Cells[0].Text);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Txt_delete.Text == "")
        {

        }
        else
        {

            using (DataSetTableAdapters.Select_soalTableAdapter del1 = new DataSetTableAdapters.Select_soalTableAdapter())
            {
                del1.Delete(Convert.ToInt32(Txt_delete.Text));
                Response.Redirect("~/Admin/insert_news - Copy.aspx");
            }

        }
   
}




}