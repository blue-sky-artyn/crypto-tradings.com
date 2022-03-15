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



        #region test1

        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[3] { new DataColumn("attr"), new DataColumn("val"), new DataColumn("unit") });
        ViewState["spec"] = dt;
        this.BindGrid();


        #endregion
    }

    protected void BindGrid()
    {
        GridView2.DataSource = (DataTable)ViewState["spec"];
        GridView2.DataBind();
    }



    protected void BindGridView()
    {
        //Data Source=195.154.45.10,2014;Initial Catalog=iamcccom_uhsconew;Persist Security Info=True;User ID=iamcccom_uhsco;Password=Admin@2020
        //string sCon = "Data Source=195.154.45.10,2014;Initial Catalog=iamcccom_uhsconew;Persist Security Info=True;User ID=iamcccom_uhsco;Password=Admin@2020";
        //string sCon = @"Data Source=FARHAD-ASUS\SQL2017;Initial Catalog=Crypto;Integrated Security=True;";
        string sCon = "Data Source=195.154.45.10,2014;Initial Catalog=iamcccom_uhsconew;Persist Security Info=True;User ID=iamcccom_uhsco;Password=Admin@2020";

        using (SqlConnection sqlCon = new SqlConnection(sCon))
        {
            sqlCon.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Admin", sqlCon);
            DataTable dtTbl = new DataTable();

            sqlDa.Fill(dtTbl);

            DataGrid1.DataSource = dtTbl;








           
        }
    }

}