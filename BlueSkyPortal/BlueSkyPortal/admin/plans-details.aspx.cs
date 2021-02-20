using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_palns : System.Web.UI.Page
{
    string id_plan1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Loginadmin"] == null)
        {
            Response.Redirect("login.aspx");
        }

        {
                if (Request.QueryString["id"] != "")
                {
                    id_plan1 = Request.QueryString["id"];
                if (!IsPostBack)
                {
                    using (DataSetTableAdapters.Sub_plansTableAdapter ins1 = new DataSetTableAdapters.Sub_plansTableAdapter())
                    {
                        DataSet.Sub_plansDataTable ne1 = ins1.Search_subplanid(Convert.ToInt32(id_plan1));
                        foreach (DataSet.Sub_plansRow row3 in ne1)
                        {
                            txt_nameplan.Text = row3.Name_plan;
                            txt_max.Text = row3.Max_price;
                            txt_min.Text = row3.Min_price;
                            txt_period.Text = Convert.ToString(row3.Period);
                            txt_sent.Text = row3.Darsad;
                            txt_vam.Text = row3.Debit;
                            txt_walet.Text = row3.Adress_valet;
                            txt_moaref.Text = row3.Moaref_darsad;
                            txt_Details.Text = row3.Desc_subplan;
                            DropDownList1.SelectedValue = Convert.ToString(row3.Statuse_subplan);

                        }

                    }
                }
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //اعتبار سنجی



        using (DataSetTableAdapters.Sub_plansTableAdapter ins1 = new DataSetTableAdapters.Sub_plansTableAdapter())
        {

            ins1.update_subplan22(txt_nameplan.Text, txt_nameplan.Text, txt_min.Text,txt_max.Text, Convert.ToInt32(txt_period.Text), txt_sent.Text, txt_vam.Text, txt_moaref.Text, "",txt_Details.Text, txt_walet.Text,Convert.ToInt32( DropDownList1.SelectedValue), Convert.ToInt32(id_plan1), Convert.ToInt32(id_plan1));
            Response.Redirect("~/Admin/Default.aspx");
        }
    }
}