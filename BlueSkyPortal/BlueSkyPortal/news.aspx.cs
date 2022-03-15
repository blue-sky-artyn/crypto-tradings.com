using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_news : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



        string s1;
        s1 = "";


        using (DataSetTableAdapters.newsTableAdapter ins = new DataSetTableAdapters.newsTableAdapter())
        {
            DataSet.newsDataTable ne = ins.Select_new11();
            foreach (DataSet.newsRow row1 in ne)
            {

               



                s1 += "<div class='col-lg-4 col-md-4 col-sm-12 col-xs-12 wow fadeIn'data-wow-duration='1s' data-wow-delay'0.2s'>";
                s1+= "<div class='widget clearfix'>";
                s1 += "<img  src='img1_news/"+row1.Pic_news+"' alt='' class='img-responsive'>";
                s1 += "<div class='widget-title'>";
                s1 += "<h3>'"+row1.Titr_new+"'</h3>";
               
                s1 += "</div>";
                s1 += "<!-- end title -->";
                s1 += " <p>'"+row1.Matn_news+"'</p>";
                s1 += " <hr>";
                s1 += "<a href ='news-details.aspx?grp="+row1.ID_news+"' data-scroll class='btn btn-light grd1 effect-1 btn-radius btn-brd'>Order Now</a>";
                s1 += "</div>";
                s1 += "<!--widget -->";
                s1 += "</div>";

   













            }
        }

        Literal1.Text = s1;



    }
}