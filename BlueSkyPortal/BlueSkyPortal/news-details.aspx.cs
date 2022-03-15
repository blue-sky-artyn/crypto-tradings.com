using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class news_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        string id1;
        string s1;
        string s2;
        string s3;
        s1 = "";
        s2 = "";
        s3 = "";

        if (Request.QueryString["grp"] != "")
        {
            id1 = Request.QueryString["grp"];

            using (DataSetTableAdapters.newsTableAdapter ins = new DataSetTableAdapters.newsTableAdapter())
            {
                DataSet.newsDataTable ne = ins.search_news_id(Convert.ToInt32(id1));
                foreach (DataSet.newsRow row1 in ne)
                {


                    s1 = row1.Titr_new;
                    s2 = row1.Statuse_new;
                    s3 = "<img src='img1_news/"+row1.Pic_news+"' alt='bondelectric company' class='img-responsive img-rounded'>";




                }
            }

            Literal1.Text = s1;
            Literal2.Text = s2;
            Literal3.Text = s3;
        }
    }
}