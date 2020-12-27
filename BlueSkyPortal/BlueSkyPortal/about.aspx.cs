using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_about : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        #region header top picture
        tblLogsCollection picTopTbl = new tblLogsCollection();
        picTopTbl.ReadList();

        if (picTopTbl.Count > 0)
            headerPicHtml.Attributes["style"] = "background: url(" + picTopTbl[0].logDetail + ")no-repeat;background-size: cover;background-position: center;";
        #endregion




        #region company details

        tblCompanyCollection coDetTbl = new tblCompanyCollection();
        coDetTbl.ReadList();

        ownerWordHtml.InnerHtml = coDetTbl[0].CoOwnerWord;
        coDetHtml.InnerHtml = coDetTbl[0].CoDetail;
        #endregion






        string portfolioStr = string.Empty;
        int counter = 0;
        tblPortfolioCompanyCollection companyPortfolioTbl = new tblPortfolioCompanyCollection();
        companyPortfolioTbl.ReadList();

        tblCompanyHonorsCollection companyHonorTbl = new tblCompanyHonorsCollection();
        companyHonorTbl.ReadList();

        portfolioStr += "<div class='row'>";

        for (int i = 0; i < companyPortfolioTbl.Count; i++)
        {
            if (counter == 4)
            {
                portfolioStr += "</div><div class='row'>";
                counter = 0;
                portfolioStr += "<div class='col-md-4 col-sm-6 col-xs-12'><div class='icon-wrapper-portfolio wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s'>"+
                        "<img class='portfolio-img' src='images/portfolio/"+companyPortfolioTbl[i].picName+ "' alt='" + companyPortfolioTbl[i].picName + "' /><h3>" + companyPortfolioTbl[i].title + "</h3>" +
                        "<p class='portfolio-para'>" + companyPortfolioTbl[i].details + "<small class='readmore'><a href='#'>Read more</a></small></p></div></div>";

            }
            counter++;
        }

        portfolioStr += "</div>";

        portfolioHtml.InnerHtml = portfolioStr;
    }
}