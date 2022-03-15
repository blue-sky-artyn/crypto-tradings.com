using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_In_plans : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Login_admin"] == null)
            Response.Redirect("~/Admin/Login_admin.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //اعتبار سنجی ها ************



        //********************


        using (DataSetTableAdapters.Sub_plansTableAdapter ins1 = new DataSetTableAdapters.Sub_plansTableAdapter())
        {

            ins1.Insert (Convert.ToInt32(DropDownList1.SelectedValue.ToString()), DropDownList1.Text,Txt_nameplan.Text, Txt_min.Text, Txt_max.Text,Convert.ToInt32( Txt_period.Text), Txt_dasad.Text, Txt_vam.Text, Txt_moaref.Text,Txt_remove.Text,Txt_descplan.Text,Txt_valet.Text,1);
           // Response.Redirect("~/Admin/Insert_mp3.aspx");
        }








    }
}