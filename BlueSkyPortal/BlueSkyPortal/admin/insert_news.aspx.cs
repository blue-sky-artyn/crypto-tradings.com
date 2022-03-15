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

        if (FileUpload1.HasFile)
        {
            string str = FileUpload1.FileName;
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/img1_news/" + str));
            string Image = FileUpload1.PostedFile.FileName;

            string matn = txt_text.Text;
            int length = matn.Length;
            string str2;
            if (length > 50)
            {

                 str2 = matn.Substring(0, 50);
            }
            else
            {
                 str2 = matn;
            }


            using (DataSetTableAdapters.newsTableAdapter ins12 = new DataSetTableAdapters.newsTableAdapter())
            {

                ins12.Insert(txt_titr.Text, str2, txt_text.Text,0,Image,"");

                Response.Redirect("default.aspx");
            }
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

            using (DataSetTableAdapters.newsTableAdapter del1 = new DataSetTableAdapters.newsTableAdapter())
            {
                del1.Delete(Convert.ToInt32(Txt_delete.Text));
                Response.Redirect("~/Admin/insert_news.aspx");
            }

        }









    }
}