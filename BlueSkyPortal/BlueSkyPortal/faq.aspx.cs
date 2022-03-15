using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class faq : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string s1;
        s1 = "";


        using (DataSetTableAdapters.Select_soalTableAdapter   ins = new DataSetTableAdapters.Select_soalTableAdapter())
        {
            DataSet.Select_soalDataTable ne = ins.Select_soal3();
            foreach (DataSet.Select_soalRow row1 in ne)
            {
                s1 += "<div class='col-md-4 col-sm-6 col-x-12'>";
                s1 += "<div class='testimonial clearfix'>";
                s1 += "<div class=desc>";
                s1 += "<h3><i class='fa fa-commenting'></i>"+row1.Soal+"</h3>";
                s1 += "<p class='lead'>"+row1.Javab+"</p>";
                s1 += "</div>";
                s1 += "</div></div>";


            }

        }



        Literal1.Text = s1;           
                           
                           
                    

    }
}