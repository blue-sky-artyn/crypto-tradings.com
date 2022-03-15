using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Insert_plans1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Loginadmin"] == null)
        {
            Response.Redirect("login.aspx");
        }
        using (DataSetTableAdapters.PlanTableAdapter ins1 = new DataSetTableAdapters.PlanTableAdapter())
        {
            DataSet.PlanDataTable ne1 = ins1.select_plan24(1);
            foreach (DataSet.PlanRow row3 in ne1)
            {
                txtn1.Text = row3.Statuse1_plan;
                txt_d1.Text = row3.Desc_plan;

            }


        }


        using (DataSetTableAdapters.PlanTableAdapter ins18 = new DataSetTableAdapters.PlanTableAdapter())
        {
            DataSet.PlanDataTable ne18 = ins18.select_plan24(2);
            foreach (DataSet.PlanRow row38 in ne18)
            {
                txtn2.Text = row38.Statuse1_plan;
                txtd2.Text = row38.Desc_plan;

            }


        }
        //*****************
        using (DataSetTableAdapters.PlanTableAdapter ins12 = new DataSetTableAdapters.PlanTableAdapter())
        {
            DataSet.PlanDataTable ne12 = ins12.select_plan24(3);
            foreach (DataSet.PlanRow row32 in ne12)
            {
                txtn3.Text = row32.Statuse1_plan;
                txtd3.Text = row32.Desc_plan;

            }


        }
        //********************
        using (DataSetTableAdapters.PlanTableAdapter ins134 = new DataSetTableAdapters.PlanTableAdapter())
        {
            DataSet.PlanDataTable ne134 = ins134.select_plan24(4);
            foreach (DataSet.PlanRow row334 in ne134)
            {
                txtn4.Text = row334.Statuse1_plan;
                txtd4.Text = row334.Desc_plan;

            }


        }
        //****************************
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        using (DataSetTableAdapters.PlanTableAdapter ins5 = new DataSetTableAdapters.PlanTableAdapter())
        {

            ins5.update_plan2(1,txtn1.Text,txt_d1.Text);           
        }
        //*****************
        using (DataSetTableAdapters.PlanTableAdapter ins52 = new DataSetTableAdapters.PlanTableAdapter())
        {

            ins52.update_plan2(2, txtn2.Text, txtd2.Text);
        }
        //*********************
        using (DataSetTableAdapters.PlanTableAdapter ins53 = new DataSetTableAdapters.PlanTableAdapter())
        {

            ins53.update_plan2(3, txtn3.Text, txtd3.Text);
        }
        //***************
        using (DataSetTableAdapters.PlanTableAdapter ins54 = new DataSetTableAdapters.PlanTableAdapter())
        {

            ins54.update_plan2(4, txtn4.Text, txtd4.Text);
        }

        Response.Redirect("Default.aspx");

    }
}