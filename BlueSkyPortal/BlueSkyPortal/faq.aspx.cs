using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class faq : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string faqStr = "<div class='row'>";
        int counter = 0;
        tblFAQCollection faqTbl = new tblFAQCollection();
        faqTbl.ReadList();

        for (int i = 0; i < faqTbl.Count; i++)
        {
            if (counter == 3)
            {
                faqStr += "</div><div class='row'>";
                counter = 0;
            }
            faqStr += "<div class='col-md-4 col-sm-6 col-xs-12'><div class='testimonial clearfix'>"+
                        "<div class='desc'><h3><i class='fa fa-commenting'></i> "+faqTbl[i].faqTitle+"</h3>" +
                        "<p class='lead'>" + faqTbl[i].faqDetail + "</p></div>" +
						"</div></div>";
            counter++;
        }

        faqStr += "</div>";


        faqHtml.InnerHtml = faqStr;

        #region header top picture
        tblLogsCollection picTopTbl = new tblLogsCollection();
        picTopTbl.ReadList();
        if (picTopTbl.Count > 0)
            headerPicHtml.Attributes["style"] = "background: url(" + picTopTbl[0].logDetail + ")no-repeat;background-size: cover;background-position: center;";
        #endregion

    }
}