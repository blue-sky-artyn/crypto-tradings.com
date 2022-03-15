using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class connect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindGridView();
        }
    }

    protected void BindGridView()
    {
        //Data Source=195.154.45.10,2014;Initial Catalog=iamcccom_uhsconew;Persist Security Info=True;User ID=iamcccom_uhsco;Password=Admin@2020
        string sCon = "Data Source=195.154.45.10,2014;Initial Catalog=iamcccom_uhsconew;Persist Security Info=True;User ID=iamcccom_uhsco;Password=Admin@2020";

        using (SqlConnection con = new SqlConnection(sCon))
        {
            using (SqlCommand cmd = new SqlCommand("select * from iamcccom_uhsconew.dbo.Admin"))
            {
                SqlDataAdapter sda = new SqlDataAdapter();

                try
                {
                    cmd.Connection = con;
                    con.Open();
                    sda.SelectCommand = cmd;

                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    //Error
                }
            }
        }
    }


    protected void GridView1_PageIndexChanging(object sender, EventArgs e)
    {
        //GridView1.PageIndex = e.NewPage

    }
}