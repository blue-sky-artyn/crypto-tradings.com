using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_information : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string infStr = "<div class='row'>" ;
        int counter = 0;
        tblInformationPicCollection infPicTbl = new tblInformationPicCollection();
        tblInformationDetailCollection infTbl = new tblInformationDetailCollection();
        infTbl.ReadList();

        for (int i = 0; i < infTbl.Count; i++)
        {
            if (counter == 4)
            {
                infStr = "</div><hr class='hr3'><div class='row'>";
                counter = 0;
            }
            infPicTbl.ReadList(Criteria.NewCriteria(tblInformationPic.Columns.infId, CriteriaOperators.Equal, infTbl[i].id));
            infStr += "<div class='col-md-4 col-sm-6 col-xs-12'><div class='icon-wrapper-portfolio wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s'>";
            if (infTbl[i].frontFile.Length > 0)
                infStr += "<img class='portfolio-img' src='images/info/" + infTbl[i].frontFile + "' alt='bondelectric " + infTbl[i].frontFile + "' />";

            infStr += "<h3>" + infTbl[i].infDetailTitle + "</h3>" +
                        "<p class='portfolio-para'>" + infTbl[i].infDetailDescription + "<small class='readmore'><a href='information-details.aspx?itemNo=" + infTbl[i].id + "'>Read more</a></small></p></div></div>";
            counter++;
        }

        infStr += "</div>";

        infHtml.InnerHtml = infStr;

        #region header top picture
        tblLogsCollection picTopTbl = new tblLogsCollection();
        picTopTbl.ReadList();
        if (picTopTbl.Count > 0)
            headerPicHtml.Attributes["style"] = "background: url(" + picTopTbl[0].logDetail + ")no-repeat;background-size: cover;background-position: center;";
        #endregion

    }
}