using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;
public partial class news_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["itemNo"] != null)
        {
            itemGet = int.Parse(Request.QueryString["itemNo"]);
        }
        else
            Response.Redirect("default.aspx");


        tblNewsDetailsCollection newsTbl = new tblNewsDetailsCollection();
        newsTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.id,CriteriaOperators.Equal,Convert.ToInt32(itemGet)));

        newsDetHtml.InnerHtml = "<h4>" + newsTbl[0].newsDetInsertDate + "</h4>" +
                                "<h2>" + newsTbl[0].newsDetTitle + "</h2>" +
                                "<p class='lead'>" + newsTbl[0].newsDetSubtitle + "</p>" +
                                "<p>" + newsTbl[0].newsDetDetails + "</p>";

        if (newsTbl[0].topPageFileType == 0)
            newsImgHtml.InnerHtml = "<img src='" + newsTbl[0].topPageFileAddr + "' alt='bondelectric " + newsTbl[0].topPageFileAddr + "' class='img-responsive img-rounded'>";
        else if (newsTbl[0].topPageFileType == 0)
            newsImgHtml.InnerHtml = "<div><video id='video1'><source src='movie/news/" + newsTbl[0].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>";
        else
            newsImgHtml.InnerHtml = newsTbl[0].topPageFileAddr;

       

    }
}