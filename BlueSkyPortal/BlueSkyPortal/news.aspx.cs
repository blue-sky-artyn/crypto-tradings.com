using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_news : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string newsGrpStr = string.Empty;
        tblNewsGroupCollection newsGrpTbl = new tblNewsGroupCollection();
        newsGrpTbl.ReadList();

        #region news Group
        for (int i = 0; i < newsGrpTbl.Count; i++)
        {
            newsGrpStr += "<li><a class='btn btn-light grd1 effect-1 btn-radius btn-brd' href='news.aspx?itemId=" + newsGrpTbl[i].id + "'>" + newsGrpTbl[i].newsGroupTitle + "</a><li>";
        }
        newsGrpHtml.InnerHtml = newsGrpStr;

        #endregion
        
        string newsDetStr = "<div class='row dev-list text-center'>";
        int counter = 0;
        tblNewsPicCollection newsPicTbl = new tblNewsPicCollection();
        tblNewsDetailsCollection newsDetTbl = new tblNewsDetailsCollection();

        int itemGet = 0;
        if (Request.QueryString["itemId"] != null)
        {
            itemGet = int.Parse(Request.QueryString["itemId"]);
            newsDetTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.idGroup, CriteriaOperators.Equal, itemGet));
        }
        else
            newsDetTbl.ReadList();

        #region news
        for (int i = 0; i < newsDetTbl.Count; i++)
        {
            if (counter == 4)
            {
                newsDetStr = "</div><div class='row dev-list text-center'>";
                counter = 0;
            }
            newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPic.Columns.newsId, CriteriaOperators.Equal, newsDetTbl[i].id));
            newsDetStr += "<div class='col-lg-4 col-md-4 col-sm-12 col-xs-12 wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s'>" +
                        "<div class='widget clearfix'>";
            //picture
            if (newsDetTbl[i].topPageFileType == 0)
                newsDetStr += "<img src='" + newsDetTbl[i].topPageFileAddr + "' alt='bondelectric " + newsDetTbl[i].newsDetTitle + "' class='img-responsive'>";
            //movie
            else if (newsDetTbl[i].topPageFileType == 1)
                newsDetStr += "<div><video id='video1'><source src='" + newsDetTbl[i].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>";
            //external link
            else
                newsDetStr += newsDetTbl[i].topPageFileAddr;

            newsDetStr += "<div class='widget-title'><h3>" + newsDetTbl[i].newsDetTitle + "</h3><small>" + newsDetTbl[i].newsDetSubtitle + "</small></div>" +
                        "<p>" + newsDetTbl[i].newsDetGist + "</p>" +
                        "<hr><a href='news-details.aspx?itemNo=" + newsDetTbl[i].id + "' data-scroll class='btn btn-light grd1 effect-1 btn-radius btn-brd'>Read more</a></div></div>";

            counter++;
        }
        newsDetStr += "</div>";
        newsDetHtml.InnerHtml = newsDetStr;

        #endregion

        #region header top picture
        tblLogsCollection picTopTbl = new tblLogsCollection();
        picTopTbl.ReadList();
        if (picTopTbl.Count > 0)
            headerPicHtml.Attributes["style"] = "background: url(" + picTopTbl[0].logDetail + ")no-repeat;background-size: cover;background-position: center;";
        #endregion

    }
}