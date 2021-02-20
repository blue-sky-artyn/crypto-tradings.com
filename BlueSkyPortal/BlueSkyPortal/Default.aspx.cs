using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Xml.Linq;


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Literal10.Text = "";
        string s1;
        string s2;
        string s3;
        string s4;
        string s5;
        string s6;
        string s7;
        string s8;
        s1 = "";
        s2 = "";
        s3 = "";
        s4 = "";
        s5 = "";
        s6 = "";
        s7 = "";
        s8 = "";
        //مشخصات پلن

        using (DataSetTableAdapters.PlanTableAdapter ins11 = new DataSetTableAdapters.PlanTableAdapter())
        {
            DataSet.PlanDataTable ne11 = ins11.select_plan1(1);
            foreach (DataSet.PlanRow row3 in ne11)
            {
                s1 = row3.Statuse1_plan;
                s2 = row3.Desc_plan;

            }

        }
        //***************پلن2
        using (DataSetTableAdapters.PlanTableAdapter ins11 = new DataSetTableAdapters.PlanTableAdapter())
        {
            DataSet.PlanDataTable ne11 = ins11.select_plan1(2);
            foreach (DataSet.PlanRow row3 in ne11)
            {
                s3 = row3.Statuse1_plan;
                s4 = row3.Desc_plan;
            }

        }

        //*********پلن3
        using (DataSetTableAdapters.PlanTableAdapter ins11 = new DataSetTableAdapters.PlanTableAdapter())
        {
            DataSet.PlanDataTable ne11 = ins11.select_plan1(3);
            foreach (DataSet.PlanRow row3 in ne11)
            {
                s5 = row3.Statuse1_plan;
                s6 = row3.Desc_plan;

            }

        }
        //*************

        //***********پلن4
        using (DataSetTableAdapters.PlanTableAdapter ins11 = new DataSetTableAdapters.PlanTableAdapter())
        {
            DataSet.PlanDataTable ne11 = ins11.select_plan1(4);
            foreach (DataSet.PlanRow row3 in ne11)
            {
                s7 = row3.Statuse1_plan;
                s8 = row3.Desc_plan;

            }

        }
        Literal1.Text = s1;
        Literal2.Text = s2;

        Literal3.Text = s3;
        Literal4.Text = s4;

        Literal5.Text = s5;
        Literal6.Text = s6;

        Literal7.Text = s7;
        Literal8.Text = s8;
        //*************************





        string value = "";
      
            if (Request.Cookies["jackpotC"] != null)
        {

            if (Request.Cookies["Logincustomer"] == null)
            {
                Literal9.Text = "<h4 style='color: red'>  You must register first </h4>";
            }

            else
            {
                int status1;
                status1 = 0;
                DateTime localDate = DateTime.Now;
                string date1;
                date1 = Convert.ToString(localDate);
                date1 = date1.Remove(10, 9);
                using (DataSetTableAdapters.shansTableAdapter ins11 = new DataSetTableAdapters.shansTableAdapter())
                {
                    DataSet.shansDataTable ne11 = ins11.search_emailshans_customer((Convert.ToString(Session["email_customer"])), date1);
                    foreach (DataSet.shansRow row3 in ne11)
                    {
                        status1 = 1;
                        Literal9.Text = "<h4 style='color: red'>  You must deposit first </h4>";
                        Literal10.Text = " <a href ='Payment1.aspx' > Payment </a>";




                    }

                }

                if (status1 == 0)
                {
                    value = Request.Cookies["jackpotC"].Value;
                    txt1.InnerText = value.Substring(0, 1);
                    txt2.InnerText = value.Substring(1, 1);
                    txt3.InnerText = value.Substring(2, 1);
                    txt4.InnerText = value.Substring(3, 1);
                    txt5.InnerText = value.Substring(4, 1);
                    txt6.InnerText = value.Substring(5, 1);
                    txt7.InnerText = value.Substring(6, 1);
                    txt8.InnerText = value.Substring(7, 1);
                    txt9.InnerText = value.Substring(8, 1);
                    txt10.InnerText = value.Substring(9, 1);


                    
                   


                    using (DataSetTableAdapters.shansTableAdapter ins1 = new DataSetTableAdapters.shansTableAdapter())
                    {

                        ins1.Insert(((Convert.ToString(Session["email_customer"]))), date1, 0, "");
                           
                        //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                    }






                }
            }

        }
        Response.Cookies["jackpotC"].Expires = DateTime.Now.AddDays(-1);
        
    }

    protected void btnSubscriber_Click(object sender, EventArgs e)
    {

    }

    protected void jackpotClick_Click1(object sender, EventArgs e)
    {
        
    }
}